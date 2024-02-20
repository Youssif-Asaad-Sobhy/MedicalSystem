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
    }
}
