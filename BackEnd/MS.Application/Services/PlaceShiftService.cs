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
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Shift;
using MS.Application.Helpers.Pagination;

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
            if (PlaceShift is null||ID==0)
            {
                return ResponseHandler.BadRequest<PlaceShift>($"PlaceShift with ID {ID} not found.");
            }
            await _unitOfWork.PlaceShifts.DeleteAsync(PlaceShift);
            return ResponseHandler.Deleted<PlaceShift>();
        }

        public async Task<Response<PlaceShift>> GetPlaceShiftAsync(int ID)
        {
            var PlaceShift = await _unitOfWork.PlaceShifts.GetByIdAsync(ID);
            if (PlaceShift is null|| ID == 0)
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
        public async Task<PaginatedResult<List<DetailedPlaceShift>>> GetAllPlaceShiftAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedPlaceShift>();
            var placeShifts = await _unitOfWork.PlaceShifts.GetAllFilteredAsync(filter, [d=>d.Shift]);

            if (!search.IsNullOrEmpty())
            {
                placeShifts = placeShifts.Where(p => p.Shift.Name.Contains(search));
            }

            if (placeShifts is null)
            {
                return ResponseHandler.BadRequest<List<DetailedPlaceShift>>(pageFilter, "PlaceShift model is null or not found");
            }

            foreach (PlaceShift placeShift in placeShifts)
            {
                var detailedPlaceShift = new DetailedPlaceShift()
                {
                    ID = placeShift.ID,
                    EntityID = placeShift.EntityID,
                    PlaceType = placeShift.PlaceType,
                    ShiftID = placeShift.ShiftID,
                    Shift = new DetailedShift
                    {
                        ID = placeShift.Shift.ID,
                        Name = placeShift.Shift.Name,
                        StartTime = placeShift.Shift.StartTime,
                        EndTime = placeShift.Shift.EndTime,
                        EntityID = placeShift.Shift.EntityID,
                        PlaceType = placeShift.Shift.PlaceType
                    }
                };

                OutputList.Add(detailedPlaceShift);
            }

            var count = OutputList.Count();
            var detailedPlaceShifts = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedPlaceShifts, pageFilter, count);
        }
    }
}
