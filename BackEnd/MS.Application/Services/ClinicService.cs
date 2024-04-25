using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Clinc;
using MS.Application.Helpers.Filters;
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
        private IFilter<Clinic> _filter;
        public ClinicService(IUnitOfWork unitOfWork, IFilter<Clinic> filter)
        {
            _unitOfWork = unitOfWork;
            _filter = filter;
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
            await _unitOfWork.Clinics.AddAsync(clinic);
            return ResponseHandler.Created(clinic);
        }

        public async Task<Response<Clinic>> DeleteClinicAsync(int ClinicID)
        {
            var clincic = await _unitOfWork.Clinics.GetByIdAsync(ClinicID);
            if (clincic is null)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {ClinicID} not found.");
            }
            await _unitOfWork.Clinics.DeleteAsync(clincic);
            return  ResponseHandler.Deleted<Clinic>();
        }
     
       
        public async Task<Response<Clinic>> GetClinicAsync(int ClinicID)
        {
            var clincic= await _unitOfWork.Clinics.GetByIdAsync(ClinicID);
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
            var clinic = await _unitOfWork.Clinics.GetByIdAsync(model.ID);
            if (clinic is null ||clinic.ID==0)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {model.ID} not found.");
            }
            clinic.Name = model.Name;
            clinic.DepartmentID = model.DepartmentID;
            await _unitOfWork.Clinics.UpdateAsync(clinic);
            return ResponseHandler.Updated(clinic);
        }
        public async Task<Response<IEnumerable<Clinic>>> GetAllClinicsWithDepartmentIdAsync(int departmentId)
        {
            var clinics = await _unitOfWork.Clinics.GetByExpressionAsync(c => c.DepartmentID == departmentId);
            return ResponseHandler.Success(clinics);
        }

        public async Task<Response<List<Clinic>>> GetAllFilteredClinicsAsync(RootFilter filter)
        {
            var clinics = await _filter.GetFilterAsync(filter);
            if (clinics is null)
            {
                return ResponseHandler.BadRequest<List<Clinic>>("clinic model is null or not found");
            }
            return ResponseHandler.Success(clinics);
        }

        public async Task<Response<IEnumerable<Clinic>>> GetAllClinicsAsync()
        {
            var clinics = await _unitOfWork.Clinics.GetAllAsync();
             if(clinics is null)
             {
                return ResponseHandler.BadRequest<IEnumerable<Clinic>>("clinic model is null or not found");
             }
            return ResponseHandler.Success(clinics);
        }
    }
}
