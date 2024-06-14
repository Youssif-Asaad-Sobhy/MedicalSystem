using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.Lab;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using MS.Application.Helpers.Pagination;

namespace MS.Application.Services
{
    public class LabService : ILabService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LabService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Lab>> CreateLabAsync(CreateLabDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Lab>($"Model not found.");
            }
            var Entity = new Lab()
            {
                Name = model.Name,
                HospitalID = model.HospitalID,
                Type = model.Type,
                
            };
            await _unitOfWork.Labs.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<Lab>> DeleteLabAsync(int ID)
        {
            var Entity = await _unitOfWork.Labs.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Lab>("model is null or not found");
            }
            await _unitOfWork.Labs.DeleteAsync(Entity);
            return ResponseHandler.Deleted<Lab>();
        }

        public async Task<Response<Lab>> GetLabAsync(int ID)
        {
            var Entity = await _unitOfWork.Labs.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Lab>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<Lab>> UpdateLabAsync(UpdateLabDto model)
        {
            var Entity = await _unitOfWork.Labs.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Lab>("model is null or not found");
            }
            Entity.Name = model.Name;
            Entity.HospitalID = model.HospitalID;
            Entity.Type = model.Type;
            await _unitOfWork.Labs.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        public async Task<Response<IEnumerable<Lab>>> GetLabsAsync()
        {
            var labs = await _unitOfWork.Labs.GetAllAsync();
            return ResponseHandler.Success(labs);
        } 
        public async Task<PaginatedResult<List<DetailedLab>>> GetAllLabAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedLab>();
            var labs = await _unitOfWork.Labs.GetAllFilteredAsync(filter);

            if (!search.IsNullOrEmpty())
            {
                labs = labs.Where(l => l.Name.Contains(search));
            }

            if (labs is null)
            {
                return ResponseHandler.BadRequest<List<DetailedLab>>(pageFilter, "Lab model is null or not found");
            }

            foreach (Lab lab in labs)
            {
                var detailedLab = new DetailedLab()
                {
                    ID = lab.ID,
                    Name = lab.Name,
                    Type = lab.Type,
                    HospitalID = lab.HospitalID,
                    Hospital = new DetailedHospital
                    {
                        ID = lab.Hospital.ID,
                        Name = lab.Hospital.Name,
                        Phone = lab.Hospital.Phone,
                        Government = lab.Hospital.Government,
                        City = lab.Hospital.City,
                        Country = lab.Hospital.Country,
                        Type = lab.Hospital.Type
                    }
                };

                OutputList.Add(detailedLab);
            }

            var count = OutputList.Count();
            var detailedLabs = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedLabs, pageFilter, count);
        }
    }
}
