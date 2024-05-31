using MS.Application.DTOs.Disease;
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
    public class DiseaseService : IDiseaseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DiseaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Disease>> CreateDiseaseAsync(CreateDiseaseDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Disease>($"Model not found.");
            }
            var Entity = new Disease()
            {
                Name = model.Name,
                Description = model.Description,
                Symptoms = model.Symptoms,
                Causes = model.Causes
            };
            await _unitOfWork.Diseases.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }
        
        public async Task<Response<Disease>> DeleteDiseaseAsync(int ID)
        {
            var Entity = await _unitOfWork.Diseases.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Disease>("Disease not found");
            }
            await _unitOfWork.Diseases.DeleteAsync(Entity);
            return ResponseHandler.Deleted<Disease>();
        }

        public async Task<Response<Disease>> UpdateDiseaseAsync(UpdateDiseaseDto model)
        {
            var Entity = await _unitOfWork.Diseases.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Disease>("Disease not found");
            }
            Entity.Name = model.Name;
            Entity.Description = model.Description;
            Entity.Symptoms = model.Symptoms;
            Entity.Causes = model.Causes;
            await _unitOfWork.Diseases.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        
        public async Task<Response<Disease>> GetDiseaseAsync(int ID)
        {
            var Entity = await _unitOfWork.Diseases.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Disease>("Disease not found");
            }
            return ResponseHandler.Success(Entity);
        }
    } 
}
