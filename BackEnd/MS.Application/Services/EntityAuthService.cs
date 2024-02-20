using MS.Application.DTOs.EntityAuth;
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
    public class EntityAuthService : IEntityAuthService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EntityAuthService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<EntityAuth>> CreateEntityAuthAsync(CreateEntityAuthDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<EntityAuth>($"Model not found.");
            }
            var Entity = new EntityAuth()
            {
                EntityID = model.EntityID,
                PlaceType = model.PlaceType,
                UserID = model.UserID,
            };
            await _unitOfWork.EntityAuthes.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<EntityAuth>> DeleteEntityAuthAsync(int ID)
        {
            var Entity= await _unitOfWork.EntityAuthes.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<EntityAuth>("model is null or not found");
            }
            await _unitOfWork.EntityAuthes.DeleteAsync(Entity);
            return ResponseHandler.Deleted<EntityAuth>();
        }

        public async Task<Response<EntityAuth>> GetEntityAuthAsync(int ID)
        {
            var Entity = await _unitOfWork.EntityAuthes.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<EntityAuth>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<EntityAuth>> UpdateEntityAuthAsync(UpdateEntityAuthDto model)
        {
            var Entity = await _unitOfWork.EntityAuthes.GetByIdAsync(model.Id);
            if (Entity is null || model.Id == 0)
            {
                return ResponseHandler.BadRequest<EntityAuth>("model is null or not found");
            }
            Entity.EntityID = model.EntityID;
            Entity.UserID = model.UserID;
            Entity.PlaceType = model.PlaceType;
            await _unitOfWork.EntityAuthes.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
    }
}
