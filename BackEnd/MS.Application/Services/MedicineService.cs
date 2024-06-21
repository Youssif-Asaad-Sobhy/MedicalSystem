using MS.Application.DTOs.Lab;
using MS.Application.DTOs.Medicine;
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
using Microsoft.AspNetCore.Mvc;
using MS.Infrastructure.Contexts;
using MS.Application.DTOs.MedicineType;
using MS.Application.DTOs.Type;

namespace MS.Application.Services
{
    public class MedicineService :IMedicineService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MedicineService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Medicine>> CreateMedicineAsync(CreateMedicineDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Medicine>($"Model not found.");
            }
            var Entity = new Medicine()
            {
                Name = model.Name,
            };
            await _unitOfWork.Medicines.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }
        public async Task<Response<Medicine>> AddMedicineAsync(AddMedicineDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Medicine>($"Model not found.");
            }
            var medicine = new Medicine
            {
                Name = model.MedicineName,
                MedicineTypes = new List<MedicineType>
                {
                    new MedicineType
                    {
                        Description = model.Description,
                        SideEffects = model.SideEffects,
                        Warning = model.Warning,
                        ExpirationDate = model.ExpireDate,
                    }
                }
            };
            await _unitOfWork.Medicines.AddAsync(medicine);
            return ResponseHandler.Created(medicine);
        }
        public async Task<PaginatedResult<List<DetailedMedicineType>>> GetMedicineByIDAsync(int id,string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedMedicineType>();
            var medicineTypes = await _unitOfWork.MedicineTypes.GetAllFilteredAsync(filter, [d => d.Medicine, d => d.Types]);

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
                if(detailedMedicineType.ID==id)
                {
                    OutputList.Add(detailedMedicineType);
                }
                else
                {
                    continue;
                }
            }
            var count = OutputList.Count();
            var detailedMedicineTypes = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedMedicineTypes, pageFilter, count);
        }

        public async Task<Response<Medicine>> DeleteMedicineAsync(int ID)
        {
            var Entity = await _unitOfWork.Medicines.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Medicine>("model is null or not found");
            }
            await _unitOfWork.Medicines.DeleteAsync(Entity);
            return ResponseHandler.Deleted<Medicine>();
        }

        public async Task<Response<Medicine>> GetMedicineAsync(int ID)
        {
            var Entity = await _unitOfWork.Medicines.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Medicine>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<Medicine>> UpdateMedicineAsync(UpdateMedicineDto model)
        {
            var Entity = await _unitOfWork.Medicines.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Medicine>("model is null or not found");
            }
            Entity.Name = model.Name;
            await _unitOfWork.Medicines.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        public async Task<PaginatedResult<List<DetailedMedicine>>> GetAllMedicineAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedMedicine>();
            var medicines = await _unitOfWork.Medicines.GetAllFilteredAsync(filter);

            if (!search.IsNullOrEmpty())
            {
                medicines = medicines.Where(m => m.Name.Contains(search));
            }

            if (medicines is null)
            {
                return ResponseHandler.BadRequest<List<DetailedMedicine>>(pageFilter, "Medicine model is null or not found");
            }

            foreach (Medicine medicine in medicines)
            {
                var detailedMedicine = new DetailedMedicine()
                {
                    ID = medicine.ID,
                    Name = medicine.Name
                };

                OutputList.Add(detailedMedicine);
            }

            var count = OutputList.Count();
            var detailedMedicines = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedMedicines, pageFilter, count);
        }
    }
}
