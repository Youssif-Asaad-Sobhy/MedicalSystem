using Microsoft.Extensions.Logging;
using MS.Application.DTOs.PlaceShift;
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
    public class PlaceShiftService : IPlaceShiftService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlaceShiftService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<PlaceShift>> CreatePlaceShiftAsync(CreatePlaceShiftDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<PlaceShift>($"PlaceShift model not found.");
            }
            var PlaceShift = new PlaceShift()
            {
                EntityID = model.EntityID,
                PlaceType = model.PlaceType,
                ShiftID = model.ShiftID,
            };
            await _unitOfWork.PlaceShifts.AddAsync(PlaceShift);
            return ResponseHandler.Created(PlaceShift);
        }

        public async Task<Response<PlaceShift>> DeletePlaceShiftAsync(int ID)
        {
            var PlaceShift = await _unitOfWork.PlaceShifts.GetByIdAsync(ID);
            if (PlaceShift is null)
            {
                return ResponseHandler.BadRequest<PlaceShift>($"PlaceShift with ID {ID} not found.");
            }
            await _unitOfWork.PlaceShifts.DeleteAsync(PlaceShift);
            return ResponseHandler.Deleted<PlaceShift>();
        }

        public async Task<Response<PlaceShift>> GetPlaceShiftAsync(int ID)
        {
            var PlaceShift = await _unitOfWork.PlaceShifts.GetByIdAsync(ID);
            if (PlaceShift is null)
            {
                return ResponseHandler.BadRequest<PlaceShift>($"PlaceShift with ID {ID} not found.");
            }
            return ResponseHandler.Success<PlaceShift>(PlaceShift);
        }

        public async Task<Response<PlaceShift>> UpdatePlaceShiftAsync(UpdatePlaceShiftDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<PlaceShift>($"PlaceShift with ID {model.ID} not found.");
            }
            var PlaceShift = await _unitOfWork.PlaceShifts.GetByIdAsync(model.ID);
            if (PlaceShift is null || PlaceShift.ID == 0)
            {
                return ResponseHandler.BadRequest<PlaceShift>($"PlaceShift with ID {model.ID} not found.");
            }
            PlaceShift.ShiftID = model.ShiftID;
            PlaceShift.EntityID = model.EntityID;
            PlaceShift.PlaceType = model.PlaceType;


            await _unitOfWork.PlaceShifts.UpdateAsync(PlaceShift);
            return ResponseHandler.Updated(PlaceShift);
        }
    }
}
