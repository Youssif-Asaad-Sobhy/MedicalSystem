using Microsoft.Extensions.Logging;
using MS.Application.DTOs.MedicineType;
using MS.Application.DTOs.PharmacyMedicine;
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
using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.Medicine;
using MS.Application.DTOs.Pharmacy;
using MS.Application.DTOs.Type;
using MS.Application.Helpers.Pagination;

namespace MS.Application.Services
{
    public class PharmacyMedicineService : IPharmacyMedicineService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PharmacyMedicineService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<PharmacyMedicine>> CreatePharmacyMedicineAsync(CreatePharmacyMedicineDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>($"PharmacyMedicine model not found.");
            }
            var PharmacyMedicine = new PharmacyMedicine()
            {
                PharmacyID =model.PharmacyID,
                MedicineTypeID = model.MedicineTypeID,
                Amount = model.Amount,
                Price = model.Price,
            };
            await _unitOfWork.PharmacyMedicines.AddAsync(PharmacyMedicine);
            return ResponseHandler.Created(PharmacyMedicine);
        }

        public async Task<Response<PharmacyMedicine>> DeletePharmacyMedicineAsync(int ID)
        {
            var Entity = await _unitOfWork.PharmacyMedicines.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>("model is null or not found");
            }
            await _unitOfWork.PharmacyMedicines.DeleteAsync(Entity);
            return ResponseHandler.Deleted<PharmacyMedicine>();
        }

        public async Task<Response<PharmacyMedicine>> GetPharmacyMedicineAsync(int ID)
        {
            var Entity = await _unitOfWork.PharmacyMedicines.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<PharmacyMedicine>> UpdatePharmacyMedicineAsync(UpdatePharmacyMedicineDto model)
        {
            var Entity = await _unitOfWork.PharmacyMedicines.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>("model is null or not found");
            }
            Entity.Amount = model.Amount;
            Entity.Price = model.Price;
            Entity.MedicineTypeID = model.MedicineTypeID;
            Entity.PharmacyID = model.PharmacyID;
            await _unitOfWork.PharmacyMedicines.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        public async Task<PaginatedResult<List<DetailedPharmacyMedicine>>> GetAllPharmacyMedicineAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedPharmacyMedicine>();
            var pharmacyMedicines = await _unitOfWork.PharmacyMedicines.GetAllFilteredAsync(filter, [d=>d.Pharmacy,d=>d.Pharmacy.Hospital, d=>d.MedicineType.Medicine, d=>d.MedicineType.Types]);
            if (!search.IsNullOrEmpty())
            {
                pharmacyMedicines = pharmacyMedicines.Where(p => p.MedicineType.Medicine.Name.Contains(search));
            }
            if (pharmacyMedicines is null)
            {
                return ResponseHandler.BadRequest<List<DetailedPharmacyMedicine>>(pageFilter, "PharmacyMedicine model is null or not found");
            }
            foreach (PharmacyMedicine pharmacyMedicine in pharmacyMedicines)
            {
                var detailedPharmacyMedicine = new DetailedPharmacyMedicine()
                {
                    ID = pharmacyMedicine.ID,
                    PharmacyID = pharmacyMedicine.PharmacyID,
                    MedicineTypeID = pharmacyMedicine.MedicineTypeID,
                    Amount = pharmacyMedicine.Amount,
                    Price = pharmacyMedicine.Price,
                    Pharmacy = new DetailedPharmacy
                    {
                        ID = pharmacyMedicine.Pharmacy.ID,
                        Name = pharmacyMedicine.Pharmacy.Name,
                        HospitalID = pharmacyMedicine.Pharmacy.HospitalID,
                        Hospital = new DetailedHospital
                        {
                            ID = pharmacyMedicine.Pharmacy.Hospital.ID,
                            Name = pharmacyMedicine.Pharmacy.Hospital.Name,
                            Phone = pharmacyMedicine.Pharmacy.Hospital.Phone,
                            Government = pharmacyMedicine.Pharmacy.Hospital.Government,
                            City = pharmacyMedicine.Pharmacy.Hospital.City,
                            Country = pharmacyMedicine.Pharmacy.Hospital.Country,
                            Type = pharmacyMedicine.Pharmacy.Hospital.Type
                        }
                    },
                    MedicineType = new DetailedMedicineType
                    {
                        ID = pharmacyMedicine.MedicineType.ID,
                        MedicineID = pharmacyMedicine.MedicineType.MedicineID,
                        TypeID = pharmacyMedicine.MedicineType.TypeID,
                        Description = pharmacyMedicine.MedicineType.Description,
                        SideEffects = pharmacyMedicine.MedicineType.SideEffects,
                        Warning = pharmacyMedicine.MedicineType.Warning,
                        ExpirationDate = pharmacyMedicine.MedicineType.ExpirationDate,
                        Medicine = new DetailedMedicine
                        {
                            ID = pharmacyMedicine.MedicineType.Medicine.ID,
                            Name = pharmacyMedicine.MedicineType.Medicine.Name
                        },
                        Types = new DetailedType
                        {
                            ID = pharmacyMedicine.MedicineType.Types.ID,
                            Name = pharmacyMedicine.MedicineType.Types.Name
                        }
                    }
                };

                OutputList.Add(detailedPharmacyMedicine);
            }
            var count = OutputList.Count();
            var detailedPharmacyMedicines = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedPharmacyMedicines, pageFilter, count);
        }
    }
}
