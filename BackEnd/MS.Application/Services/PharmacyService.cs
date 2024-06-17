using Microsoft.Extensions.Logging;
using MS.Application.DTOs.MedicineType;
using MS.Application.DTOs.Pharmacy;
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
using MS.Application.Helpers.Pagination;

namespace MS.Application.Services
{
    public class PharmacyService : IPharmacyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PharmacyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Pharmacy>> CreatePharmacyAsync(CreatePharmacyDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Pharmacy>($"Model not found.");
            }
            var Entity = new Pharmacy()
            {
                Name = model.Name,
                HospitalID = model.HospitalID,
            };
            await _unitOfWork.Pharmacies.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<Pharmacy>> DeletePharmacyAsync(int ID)
        {
            var Entity = await _unitOfWork.Pharmacies.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Pharmacy>("model is null or not found");
            }
            await _unitOfWork.Pharmacies.DeleteAsync(Entity);
            return ResponseHandler.Deleted<Pharmacy>();
        }

        public async Task<Response<Pharmacy>> GetPharmacyAsync(int ID)
        {
            var Entity = await _unitOfWork.Pharmacies.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Pharmacy>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<Pharmacy>> UpdatePharmacyAsync(UpdatePharmacyDto model)
        {
            var Entity = await _unitOfWork.Pharmacies.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Pharmacy>("model is null or not found");
            }
            Entity.Name = model.Name;
            Entity.HospitalID = model.HospitalID;
            await _unitOfWork.Pharmacies.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        public async Task<PaginatedResult<List<DetailedPharmacy>>> GetAllPharmacyAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedPharmacy>();
            var pharmacies = await _unitOfWork.Pharmacies.GetAllFilteredAsync(filter, [d=>d.Hospital]);

            if (!search.IsNullOrEmpty())
            {
                pharmacies = pharmacies.Where(p => p.Name.Contains(search));
            }

            if (pharmacies is null)
            {
                return ResponseHandler.BadRequest<List<DetailedPharmacy>>(pageFilter, "Pharmacy model is null or not found");
            }

            foreach (Pharmacy pharmacy in pharmacies)
            {
                var detailedPharmacy = new DetailedPharmacy()
                {
                    ID = pharmacy.ID,
                    Name = pharmacy.Name,
                    HospitalID = pharmacy.HospitalID,
                    Hospital = new DetailedHospital
                    {
                        ID = pharmacy.Hospital.ID,
                        Name = pharmacy.Hospital.Name,
                        Phone = pharmacy.Hospital.Phone,
                        Government = pharmacy.Hospital.Government,
                        City = pharmacy.Hospital.City,
                        Country = pharmacy.Hospital.Country,
                        Type = pharmacy.Hospital.Type
                    }
                };

                OutputList.Add(detailedPharmacy);
            }

            var count = OutputList.Count();
            var detailedPharmacies = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedPharmacies, pageFilter, count);
        }
    }
}
