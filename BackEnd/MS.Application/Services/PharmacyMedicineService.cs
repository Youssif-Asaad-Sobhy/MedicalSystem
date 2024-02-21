using Microsoft.Extensions.Logging;
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
            var PharmacyMedicine = await _unitOfWork.PharmacyMedicines.GetByIdAsync(ID);
            if (PharmacyMedicine is null)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>($"PharmacyMedicine with ID {ID} not found.");
            }
            await _unitOfWork.PharmacyMedicines.DeleteAsync(PharmacyMedicine);
            return ResponseHandler.Deleted<PharmacyMedicine>();
        }

        public async Task<Response<PharmacyMedicine>> GetPharmacyMedicineAsync(int ID)
        {
            var PharmacyMedicine = await _unitOfWork.PharmacyMedicines.GetByIdAsync(ID);
            if (PharmacyMedicine is null)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>($"PharmacyMedicine with ID {ID} not found.");
            }
            return ResponseHandler.Success<PharmacyMedicine>(PharmacyMedicine);
        }

        public async Task<Response<PharmacyMedicine>> UpdatePharmacyMedicineAsync(UpdatePharmacyMedicineDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>($"PharmacyMedicine with ID {model.ID} not found.");
            }
            var PharmacyMedicine = await _unitOfWork.PharmacyMedicines.GetByIdAsync(model.ID);
            if (PharmacyMedicine is null || PharmacyMedicine.ID == 0)
            {
                return ResponseHandler.BadRequest<PharmacyMedicine>($"PharmacyMedicine with ID {model.ID} not found.");
            }
            PharmacyMedicine.PharmacyID = model.PharmacyID;
            PharmacyMedicine.MedicineTypeID = model.MedicineTypeID;
            PharmacyMedicine.Price = model.Price;
            PharmacyMedicine.Amount = model.Amount;
                
            await _unitOfWork.PharmacyMedicines.UpdateAsync(PharmacyMedicine);
            return ResponseHandler.Updated(PharmacyMedicine);
        }
    }
}
