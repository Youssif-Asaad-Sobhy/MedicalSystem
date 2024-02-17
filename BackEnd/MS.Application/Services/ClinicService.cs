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
                return new Response<Clinic>($"Clinic with ID {ClinicID} not found.", false);
            }
            await _unitOfWork.Clinincs.DeleteAsync(clincic);
            return new Response<Clinic>().Deleted<Clinic>();
        }

        public async Task<Response<Clinic>> GetClinicAsync(int ClinicID)
        {
            var clincic= await _unitOfWork.Clinincs.GetByIdAsync(ClinicID);
            if (clincic is null)
            {
                return new Response<Clinic>($"Clinic with ID {ClinicID} not found.",false);
            }
            return new Response<Clinic>(clincic);
        }

        public async Task<Response<Clinic>> UpdateClinicAsync(ClinicDto model)
        {
            if (model is null ||model.ID==0)
            {
                return new Response<Clinic>($"ClinicModel with ID {model.ID} or the model  not found .", false);
            }
            var clinic = await _unitOfWork.Clinincs.GetByIdAsync(model.ID);
            if (clinic is null ||clinic.ID==0)
            {
                return new Response<Clinic>($"Clinic with ID {model.ID} not found.", false);
            }
            clinic.Name = model.Name;
            clinic.DepartmentID = model.DepartmentID;
            throw new NotImplementedException();
        }
    }
}
