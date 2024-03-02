using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;

        public ReservationService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<Response<Reservation>> PlaceReservationAsync(PlaceReservationDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation model not found.");
            }
            var user =await _userManager.FindByIdAsync(model.UserID);
            var placePrice = await _unitOfWork.PlacePrice.GetByIdAsync(model.PlacePriceId);
            if (placePrice is null || user == null)
            {
                return ResponseHandler.BadRequest<Reservation>($"place or User not found. please enter correct ID");
            }
            var reservation = new Reservation()
            {
                Time=DateTime.Now,
                UserID=user.Id,
                PlacePriceId=model.PlacePriceId
            };
            await _unitOfWork.Reservations.AddAsync(reservation);
            return ResponseHandler.Created(reservation);
        }
        public async Task<Response<Reservation>> DeleteReservationAsync(int ID)
        {
            var Reservation = await _unitOfWork.Reservations.GetByIdAsync(ID);
            if (Reservation is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation with ID {ID} not found.");
            }
            await _unitOfWork.Reservations.DeleteAsync(Reservation);
            return ResponseHandler.Deleted<Reservation>();
        }

        public async Task<Response<Reservation>> GetReservationAsync(int ID)
        {
            var Reservation = await _unitOfWork.Reservations.GetByIdAsync(ID);
            if (Reservation is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Reservation>($"Reservation with ID {ID} not found.");
            }
            return ResponseHandler.Success(Reservation);
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
            Reservation.PlacePriceId = model.PlacePriceId;

            await _unitOfWork.Reservations.UpdateAsync(Reservation);
            return ResponseHandler.Updated(Reservation);
        }

        public async Task<Response<IEnumerable<Reservation>>> TodaysReservationsAsync()
        {
            // we must implement a query 
            var TodayRes =await _unitOfWork.Reservations.GetByExpressionAsync(r=>r.Time.Date==DateTime.Today);
            return ResponseHandler.Success(TodayRes);

        }

        
        

    }
}
