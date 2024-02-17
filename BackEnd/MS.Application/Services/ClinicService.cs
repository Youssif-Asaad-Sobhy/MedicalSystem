using Microsoft.Extensions.Logging;
using MS.Application.DTOs.Clinc;
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
    public class ClinicService : IClinicService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClinicService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Clinic>> DeleteClinicAsync(int ClinicID)
        {
            var clincic = await _unitOfWork.Clinincs.GetByIdAsync(ClinicID);
            if (clincic is null)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {ClinicID} not found.");
            }
            await _unitOfWork.Clinincs.DeleteAsync(clincic);
            return  ResponseHandler.Deleted<Clinic>();
        }

        public async Task<Response<Clinic>> GetClinicAsync(int ClinicID)
        {
            var clincic= await _unitOfWork.Clinincs.GetByIdAsync(ClinicID);
            if (clincic is null)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {ClinicID} not found.");
            }
            return ResponseHandler.Success(clincic);
        }

        public async Task<Response<Clinic>> UpdateClinicAsync(ClinicDto model)
        {
            if (model is null ||model.ID==0)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {model.ID} not found.");
            }
            var clinic = await _unitOfWork.Clinincs.GetByIdAsync(model.ID);
            if (clinic is null ||clinic.ID==0)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {clinic.ID} not found.");
            }
            clinic.Name = model.Name;
            clinic.DepartmentID = model.DepartmentID;
            return ResponseHandler.Updated(clinic);
        }
    }
}
