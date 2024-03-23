using Microsoft.Extensions.Logging;
using MS.Application.DTOs.PlaceEquipment;
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
    public class PlaceEquipmentService : IPlaceEquipmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlaceEquipmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<PlaceEquipment>> CreatePlaceEquipmentAsync(CreatePlaceEquipmentDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<PlaceEquipment>($"PlaceEquipment model not found.");
            }
            var PlaceEquipment = new PlaceEquipment()
            {
                EquipmentID = model.EquipmentID,
                PlaceType = model.PlaceType,
                EntityID = model.EntityID,
            };
            await _unitOfWork.PlaceEquipments.AddAsync(PlaceEquipment);
            return ResponseHandler.Created(PlaceEquipment);
        }

        public async Task<Response<PlaceEquipment>> DeletePlaceEquipmentAsync(int ID)
        {
            var PlaceEquipment = await _unitOfWork.PlaceEquipments.GetByIdAsync(ID);
            if (PlaceEquipment is null||ID==0)
            {
                return ResponseHandler.BadRequest<PlaceEquipment>($"PlaceEquipment with ID {ID} not found.");
            }
            await _unitOfWork.PlaceEquipments.DeleteAsync(PlaceEquipment);
            return ResponseHandler.Deleted<PlaceEquipment>();
        }

        public async Task<Response<PlaceEquipment>> GetPlaceEquipmentAsync(int ID)
        {
            var PlaceEquipment = await _unitOfWork.PlaceEquipments.GetByIdAsync(ID);
            if (PlaceEquipment is null||ID==0)
            {
                return ResponseHandler.BadRequest<PlaceEquipment>($"PlaceEquipment with ID {ID} not found.");
            }
            return ResponseHandler.Success<PlaceEquipment>(PlaceEquipment);
        }

        public async Task<Response<PlaceEquipment>> UpdatePlaceEquipmentAsync(UpdatePlaceEquipmentDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<PlaceEquipment>($"PlaceEquipment with ID {model.ID} not found.");
            }
            var PlaceEquipment = await _unitOfWork.PlaceEquipments.GetByIdAsync(model.ID);
            if (PlaceEquipment is null || PlaceEquipment.ID == 0)
            {
                return ResponseHandler.BadRequest<PlaceEquipment>($"PlaceEquipment with ID {model.ID} not found.");
            }
            PlaceEquipment.EntityID = model.EntityID;
            PlaceEquipment.EquipmentID = model.EquipmentID;
            PlaceEquipment.PlaceType = model.PlaceType;

            await _unitOfWork.PlaceEquipments.UpdateAsync(PlaceEquipment);
            return ResponseHandler.Updated(PlaceEquipment);
        }
    }
}