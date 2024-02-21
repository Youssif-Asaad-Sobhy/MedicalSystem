using Microsoft.Extensions.Logging;
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
            if (model is null)
            {
                return ResponseHandler.BadRequest<Pharmacy>($"Pharmacy model not found.");
            }
            var Pharmacy = new Pharmacy()
            {
                Name = model.Name,
                HospitalID  = model.HospitalID,
            };
            await _unitOfWork.Pharmacies.AddAsync(Pharmacy);
            return ResponseHandler.Created(Pharmacy);
        }

        public async Task<Response<Pharmacy>> DeletePharmacyAsync(int ID)
        {
            var Pharmacy = await _unitOfWork.Pharmacies.GetByIdAsync(ID);
            if (Pharmacy is null)
            {
                return ResponseHandler.BadRequest<Pharmacy>($"Pharmacy with ID {ID} not found.");
            }
            await _unitOfWork.Pharmacies.DeleteAsync(Pharmacy);
            return ResponseHandler.Deleted<Pharmacy>();
        }

        public async Task<Response<Pharmacy>> GetPharmacyAsync(int ID)
        {
            var Pharmacy = await _unitOfWork.Pharmacies.GetByIdAsync(ID);
            if (Pharmacy is null)
            {
                return ResponseHandler.BadRequest<Pharmacy>($"Pharmacy with ID {ID} not found.");
            }
            return ResponseHandler.Success<Pharmacy>(Pharmacy);
        }

        public async Task<Response<Pharmacy>> UpdatePharmacyAsync(UpdatePharmacyDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Pharmacy>($"Pharmacy with ID {model.ID} not found.");
            }
            var Pharmacy = await _unitOfWork.Pharmacies.GetByIdAsync(model.ID);
            if (Pharmacy is null || Pharmacy.ID == 0)
            {
                return ResponseHandler.BadRequest<Pharmacy>($"Pharmacy with ID {model.ID} not found.");
            }
            Pharmacy.Name = model.Name;
            Pharmacy.HospitalID = model.HospitalID;

            await _unitOfWork.Pharmacies.UpdateAsync(Pharmacy);
            return ResponseHandler.Updated(Pharmacy);
        }
    }
}
