using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
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

        public async Task<Response<Clinic>> CreateClinicAsync(CreateClinicDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<Clinic>($"clinic model not found.");
            }
            var clinic = new Clinic()
            {
                Name=model.Name,
                DepartmentID=model.DepartmentID
            };
            await _unitOfWork.Clinincs.AddAsync(clinic);
            return ResponseHandler.Created(clinic);
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
        public async Task<Response<IEnumerable<Clinic>>> GetAllClinicInDepAsync(int DepId)
        {
            var clinics = await _unitOfWork.Clinincs.GetByExpressionAsync(c=>c.DepartmentID == DepId);
            if (clinics.IsNullOrEmpty())
                return ResponseHandler.BadRequest<IEnumerable<Clinic>>($"Departments Id is wrong or Department is Emprty");
            return ResponseHandler.Success(clinics);
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

        public async Task<Response<Clinic>> UpdateClinicAsync(UpdateClinicDto model)
        {
            if (model is null ||model.ID==0)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {model.ID} not found.");
            }
            var clinic = await _unitOfWork.Clinincs.GetByIdAsync(model.ID);
            if (clinic is null ||clinic.ID==0)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {model.ID} not found.");
            }
            clinic.Name = model.Name;
            clinic.DepartmentID = model.DepartmentID;
            await _unitOfWork.Clinincs.UpdateAsync(clinic);
            return ResponseHandler.Updated(clinic);
        }
    }
}
