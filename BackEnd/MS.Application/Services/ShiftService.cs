﻿using Microsoft.Extensions.Logging;
using MS.Application.DTOs.Shift;
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
    public class ShiftService : IShiftService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShiftService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<Shift>> CreateShiftAsync(CreateShiftDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<Shift>($"Shift model not found.");
            }
            var Shift = new Shift()
            {
                Name = model.Name,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                EntityID = model.EntityID,
                PlaceType = model.PlaceType,
            };
            await _unitOfWork.Shifts.AddAsync(Shift);
            return ResponseHandler.Created(Shift);
        }

        public async Task<Response<Shift>> DeleteShiftAsync(int ID)
        {
            var Shift = await _unitOfWork.Shifts.GetByIdAsync(ID);
            if (Shift is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Shift>($"Shift with ID {ID} not found.");
            }
            await _unitOfWork.Shifts.DeleteAsync(Shift);
            return ResponseHandler.Deleted<Shift>();
        }

        public async Task<Response<Shift>> GetShiftAsync(int ID)
        {
            var Shift = await _unitOfWork.Shifts.GetByIdAsync(ID);
            if (Shift is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Shift>($"Shift with ID {ID} not found.");
            }
            return ResponseHandler.Success<Shift>(Shift);
        }

        public async Task<Response<Shift>> UpdateShiftAsync(UpdateShiftDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Shift>($"Shift with ID {model.ID} not found.");
            }
            var Shift = await _unitOfWork.Shifts.GetByIdAsync(model.ID);
            if (Shift is null || Shift.ID == 0)
            {
                return ResponseHandler.BadRequest<Shift>($"Shift with ID {model.ID} not found.");
            }
            Shift.StartTime = DateTime.Now;
            Shift.EndTime = DateTime.Now;
            Shift.EntityID = model.EntityID;
            Shift.Name = model.Name;
            Shift.PlaceType = model.PlaceType;


            await _unitOfWork.Shifts.UpdateAsync(Shift);
            return ResponseHandler.Updated(Shift);
        }
    }
}
