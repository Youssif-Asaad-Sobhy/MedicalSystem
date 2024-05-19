using MS.Application.DTOs.ApplicationUserDisease;
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
    public class ApplicationUserDiseaseService : IApplicationUserDiseaseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationUserDiseaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<ApplicationUserDisease>> CreateApplicationUserDiseaseAsync(CreateApplicationUserDiseaseDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>($"Model not found.");
            }
            var Entity = new ApplicationUserDisease()
            {
                Type = model.Type,
                ValueResult = model.ValueResult,
                Description = model.Description,
                Height = model.Height,
                Weight = model.Weight,
                ApplicationUserId = model.ApplicationUserId,
                DiseaseId = model.DiseaseId,
                Diagnosis = model.Diagnosis,
                DiagnosisDate = model.DiagnosisDate
            };
            await _unitOfWork.ApplicationUserDiseases.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }
        
        public async Task<Response<ApplicationUserDisease>> DeleteApplicationUserDiseaseAsync(int ID)
        {
            var Entity = await _unitOfWork.ApplicationUserDiseases.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>("ApplicationUserDisease not found");
            }
            await _unitOfWork.ApplicationUserDiseases.DeleteAsync(Entity);
            return ResponseHandler.Deleted<ApplicationUserDisease>();
        }

        public async Task<Response<ApplicationUserDisease>> UpdateApplicationUserDiseaseAsync(UpdateApplicationUserDiseaseDto model)
        {
            var Entity = await _unitOfWork.ApplicationUserDiseases.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>("ApplicationUserDisease not found");
            }
            Entity.Type = model.Type;
            Entity.ValueResult = model.ValueResult;
            Entity.Description = model.Description;
            Entity.Height = model.Height;
            Entity.Weight = model.Weight;
            Entity.ApplicationUserId = model.ApplicationUserId;
            Entity.DiseaseId = model.DiseaseId;
            Entity.Diagnosis = model.Diagnosis;
            Entity.DiagnosisDate = model.DiagnosisDate;
            await _unitOfWork.ApplicationUserDiseases.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        
        public async Task<Response<ApplicationUserDisease>> GetApplicationUserDiseaseAsync(int ID)
        {
            var Entity = await _unitOfWork.ApplicationUserDiseases.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>("ApplicationUserDisease not found");
            }
            return ResponseHandler.Success(Entity);
        }
        
    } 
}
