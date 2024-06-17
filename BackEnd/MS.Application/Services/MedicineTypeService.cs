using MS.Application.DTOs.Medicine;
using MS.Application.DTOs.MedicineType;
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
using MS.Application.DTOs.Type;
using MS.Application.Helpers.Pagination;

namespace MS.Application.Services
{
    public class MedicineTypeService : IMedicineTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MedicineTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<MedicineType>> CreateMedicineTypeAsync(CreateMedicineTypeDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<MedicineType>($"Model not found.");
            }
            var Entity = new MedicineType()
            {
                MedicineID = model.MedicineID,
                TypeID = model.TypeID,
                Description = model.Description,
                ExpirationDate = model.ExpirationDate,
                SideEffects = model.SideEffects,
                Warning = model.Warning
            };
            await _unitOfWork.MedicineTypes.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<MedicineType>> DeleteMedicineTypeAsync(int ID)
        {
            var Entity = await _unitOfWork.MedicineTypes.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<MedicineType>("model is null or not found");
            }
            await _unitOfWork.MedicineTypes.DeleteAsync(Entity);
            return ResponseHandler.Deleted<MedicineType>();
        }

        public async Task<Response<MedicineType>> GetMedicineTypeAsync(int ID)
        {
            var Entity = await _unitOfWork.MedicineTypes.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<MedicineType>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<MedicineType>> UpdateMedicineTypeAsync(UpdateMedicineTypeDto model)
        {
            var Entity = await _unitOfWork.MedicineTypes.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<MedicineType>("model is null or not found");
            }
            Entity.MedicineID = model.MedicineID;
            Entity.TypeID = model.TypeID;
            Entity.Description = model.Description;
            Entity.ExpirationDate = model.ExpirationDate;
            Entity.SideEffects = model.SideEffects;
            Entity.Warning = model.Warning;
            await _unitOfWork.MedicineTypes.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        public async Task<PaginatedResult<List<DetailedMedicineType>>> GetAllMedicineTypeAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedMedicineType>();
            var medicineTypes = await _unitOfWork.MedicineTypes.GetAllFilteredAsync(filter, [d=>d.Medicine, d=>d.Types]);

            if (!search.IsNullOrEmpty())
            {
                medicineTypes = medicineTypes.Where(m => m.Description.Contains(search) || m.SideEffects.Contains(search) || m.Warning.Contains(search));
            }

            if (medicineTypes is null)
            {
                return ResponseHandler.BadRequest<List<DetailedMedicineType>>(pageFilter, "MedicineType model is null or not found");
            }

            foreach (MedicineType medicineType in medicineTypes)
            {
                var detailedMedicineType = new DetailedMedicineType()
                {
                    ID = medicineType.ID,
                    MedicineID = medicineType.MedicineID,
                    TypeID = medicineType.TypeID,
                    Description = medicineType.Description,
                    SideEffects = medicineType.SideEffects,
                    Warning = medicineType.Warning,
                    ExpirationDate = medicineType.ExpirationDate,
                    Medicine = new DetailedMedicine
                    {
                        ID = medicineType.Medicine.ID,
                        Name = medicineType.Medicine.Name
                    },
                    Types = new DetailedType
                    {
                        ID = medicineType.Types.ID,
                        Name = medicineType.Types.Name
                    }
                };

                OutputList.Add(detailedMedicineType);
            }

            var count = OutputList.Count();
            var detailedMedicineTypes = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedMedicineTypes, pageFilter, count);
        }
    }
}
