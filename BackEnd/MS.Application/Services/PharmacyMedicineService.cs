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
    }
}
