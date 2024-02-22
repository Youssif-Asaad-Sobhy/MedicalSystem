using Microsoft.Extensions.Logging;
using MS.Application.DTOs.Reservation;
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
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<Reservation>> CreateReservationAsync(CreateReservationDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation model not found.");
            }
            var Reservation = new Reservation()
            {
                Time = DateTime.Now,
                State = model.State,
                PlaceType = model.PlaceType,
                EntityID = model.EntityID,
                Price = model.Price,
                UserID = model.UserID,
            };
            await _unitOfWork.Reservations.AddAsync(Reservation);
            return ResponseHandler.Created(Reservation);
        }

        public async Task<Response<Reservation>> DeleteReservationAsync(int ID)
        {
            var Reservation = await _unitOfWork.Reservations.GetByIdAsync(ID);
            if (Reservation is null)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation with ID {ID} not found.");
            }
            await _unitOfWork.Reservations.DeleteAsync(Reservation);
            return ResponseHandler.Deleted<Reservation>();
        }

        public async Task<Response<Reservation>> GetReservationAsync(int ID)
        {
            var Reservation = await _unitOfWork.Reservations.GetByIdAsync(ID);
            if (Reservation is null)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation with ID {ID} not found.");
            }
            return ResponseHandler.Success<Reservation>(Reservation);
        }

        public async Task<Response<Reservation>> UpdateReservationAsync(UpdateReservationDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation with ID {model.ID} not found.");
            }
            var Reservation = await _unitOfWork.Reservations.GetByIdAsync(model.ID);
            if (Reservation is null || Reservation.ID == 0)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation with ID {model.ID} not found.");
            }
            Reservation.Time = model.Time;
            Reservation.State = model.State;
            Reservation.UserID = model.UserID;
            Reservation.EntityID = model.EntityID;
            Reservation.PlaceType= model.PlaceType;
            Reservation.Price = model.Price;

            await _unitOfWork.Reservations.UpdateAsync(Reservation);
            return ResponseHandler.Updated(Reservation);
        }
    }
}
