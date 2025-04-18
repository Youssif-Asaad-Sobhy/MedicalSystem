using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.MedicineType;
using MS.Application.DTOs.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Type;
using MS.Application.Helpers.Pagination;

namespace MS.Application.Services
{
    public class TypeServices : ITypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TypeServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<Types>> CreateTypeAsync(CreateTypeDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Types>("Type model not found.");
            }

            var type = new Types()
            {
                Name = model.Name,
            };
            await _unitOfWork.Types.AddAsync(type);
         //   await _unitOfWork.SaveChangesAsync(); // Save changes to the database
            return ResponseHandler.Created(type);
        }
        public async Task<Response<Types>> DeleteTypeAsync(int ID)
        {
            var type = await _unitOfWork.Types.GetByIdAsync(ID);
            if (type == null || ID == 0)
            {
                return ResponseHandler.BadRequest<Types>("Type model is null or not found");
            }
            await _unitOfWork.Types.DeleteAsync(type);
         //   await _unitOfWork.SaveChangesAsync(); // Save changes to the database
            return ResponseHandler.Deleted<Types>();
        }

        public async Task<Response<Types>> GetTypeAsync(int ID)
        {
            var type = await _unitOfWork.Types.GetByIdAsync(ID);
            if (type == null || ID == 0)
            {
                return ResponseHandler.BadRequest<Types>("Type model is null or not found");
            }
            return ResponseHandler.Success<Types>(type);
        }
        public async Task<Response<Types>> UpdateTypeAsync(UpdateTypeDto model)
        {
            var type = await _unitOfWork.Types.GetByIdAsync(model.ID);
            if (type == null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Types>("Type model is null or not found");
            }
            type.Name = model.Name;
         //   await _unitOfWork.SaveChangesAsync(); // Save changes to the database
            return ResponseHandler.Success(type);
        }
        public async Task<PaginatedResult<List<DetailedType>>> GetAllTypeAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedType>();
            var types = await _unitOfWork.Types.GetAllFilteredAsync(filter);

            if (!search.IsNullOrEmpty())
            {
                types = types.Where(t => t.Name.Contains(search));
            }

            if (types is null)
            {
                return ResponseHandler.BadRequest<List<DetailedType>>(pageFilter, "Type model is null or not found");
            }

            foreach (Types type in types)
            {
                var detailedType = new DetailedType()
                {
                    ID = type.ID,
                    Name = type.Name
                };

                OutputList.Add(detailedType);
            }

            var count = OutputList.Count();
            var detailedTypes = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedTypes, pageFilter, count);
        }

    }
}

