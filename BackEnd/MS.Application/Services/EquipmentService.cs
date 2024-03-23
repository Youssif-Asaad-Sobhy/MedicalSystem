using MS.Application.DTOs.Equipment;
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
    public class EquipmentService : IEquipmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EquipmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Equipment>> CreateEquipmentAsync(CreateEquipmentDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Equipment>($"Model not found.");
            }
            var Entity = new Equipment()
            {
                Description = model.Description,
                Name = model.Name,
            };
            await _unitOfWork.Equipments.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<Equipment>> DeleteEquipmentAsync(int ID)
        {
            var Entity = await _unitOfWork.Equipments.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Equipment>("model is null or not found");
            }
            await _unitOfWork.Equipments.DeleteAsync(Entity);
            return ResponseHandler.Deleted<Equipment>();
        }

        public async Task<Response<Equipment>> GetEquipmentAsync(int ID)
        {
            var Entity = await _unitOfWork.Equipments.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Equipment>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<Equipment>> UpdateEquipmentAsync(UpdateEquipmentDto model)
        {
            var Entity = await _unitOfWork.Equipments.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Equipment>("model is null or not found");
            }
            Entity.Name = model.Name;
            Entity.Description = model.Description;
            await _unitOfWork.Equipments.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
    }
}
