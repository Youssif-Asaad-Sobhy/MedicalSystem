using MS.Application.DTOs.Lab;
using MS.Application.DTOs.Medicine;
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
    public class MedicineService :IMedicineService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MedicineService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Medicine>> CreateMedicineAsync(CreateMedicineDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Medicine>($"Model not found.");
            }
            var Entity = new Medicine()
            {
                Name = model.Name,
            };
            await _unitOfWork.Medicines.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<Medicine>> DeleteMedicineAsync(int ID)
        {
            var Entity = await _unitOfWork.Medicines.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Medicine>("model is null or not found");
            }
            await _unitOfWork.Medicines.DeleteAsync(Entity);
            return ResponseHandler.Deleted<Medicine>();
        }

        public async Task<Response<Medicine>> GetMedicineAsync(int ID)
        {
            var Entity = await _unitOfWork.Medicines.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Medicine>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<Medicine>> UpdateMedicineAsync(UpdateMedicineDto model)
        {
            var Entity = await _unitOfWork.Medicines.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Medicine>("model is null or not found");
            }
            Entity.Name = model.Name;
            await _unitOfWork.Medicines.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
    }
}
