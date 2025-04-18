using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Data.Enums;
using MS.Infrastructure.Repositories.Dtos;
using MS.Infrastructure.Repositories.Generics;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.PlacePrice;

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

        public async Task<Response<ReservationDto>> PlaceReservationAsync(PlaceReservationDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<ReservationDto>($"Reservation model not found.");
            }
            var placePrice = await _unitOfWork.PlacePrice.GetByIdAsync(model.PlacePriceId);
            if (placePrice is null )
            {
                return ResponseHandler.BadRequest<ReservationDto>($"place or User not found. please enter correct ID");
            }
            var user = await _userManager.FindByIdAsync(model.UserID);

            if (user is null)
            {
               await _userManager
                    .CreateAsync(new ApplicationUser { NID=model.UserID,Id = model.UserID, UserName = model.UserID, FirstName=model.FirstName,LastName=model.LastName, IsRegister=false, Gender="female", BirthDate=DateTime.Now});
            }
            var reservation = new Reservation()
            {
                Time=DateTime.Now,
                UserID=model.UserID,
                PlacePriceId=model.PlacePriceId,
                SerialNumber= $"{DateTime.Now.TimeOfDay.TotalSeconds}{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}",
            };
            await _unitOfWork.Reservations.AddAsync(reservation);
            ReservationDto reservatioDto = new ReservationDto()
            {
                ID=reservation.ID,
                Time=reservation.Time,
                SerialNumber=reservation.SerialNumber,
                State=reservation.State,
                UserID=reservation.UserID,
                PlacePriceId=reservation.PlacePriceId
            };
            return ResponseHandler.Created(reservatioDto);
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
            Reservation.SerialNumber = model.SerialNumber;

            await _unitOfWork.Reservations.UpdateAsync(Reservation);
            return ResponseHandler.Updated(Reservation);
        }

        public async Task<PaginatedResult<IEnumerable<Reservation>>> TodaysReservationsAsync(PageFilter filter)
        {
            // we must implement a query 
            var TotalRecords = await _unitOfWork.Reservations.CountAsync(r => r.Time.Date == DateTime.Today);
            var TodayRes =await _unitOfWork.Reservations
                .GetByExpressionAsync((filter.PageNumber-1)*filter.PageSize,filter.PageSize,r=>r.Time.Date==DateTime.Today);
            return ResponseHandler.Success(TodayRes,filter,TotalRecords);

        }
        public async Task<Response<List<UserReservationDetails>>> GetUserReservationsAsync(string userId)
        {
            var reservations = await _unitOfWork.Reservations
                .GetByExpressionAsync(r => r.UserID == userId, [r => r.PlacePrice]);

            if (!reservations.Any())
            {
                return ResponseHandler.NotFound<List<UserReservationDetails>>("No reservations found for the provided user ID.");
            }
            List<UserReservationDetails> ret = new List<UserReservationDetails>();
            foreach (var reservation in reservations)
            {
                var reservationInfo = await GetReservationINFO(reservation.ID);
                var curPlace = await GetUserPlaceInClinic(new PlaceUserInClinicDto { PlaceId = reservation.PlacePrice.PlaceID, UserId = userId });
                var data = new UserReservationDetails
                {
                    firstname = reservationInfo.firstname,
                    lastname = reservationInfo.lastname,
                    Nid = reservationInfo.Nid,
                    PlaceName = reservationInfo.PlaceName,
                    Price = reservationInfo.Price,
                    Time = reservationInfo.Time,
                    Waiting = curPlace
                };
                ret.Add(data);
            }
            return ResponseHandler.Success(ret);
        }


        public async Task<ReservationINFODto> GetReservationINFO(int id)
        {
            var reservations=await _unitOfWork.Reservations.GetReservationINFO(id);
            if (reservations == null )
            {
                return null;
            }
            return reservations;
        }
        public async Task<int> GetUserPlaceInClinic(PlaceUserInClinicDto model)
        {
            DateTime day = model.ReservationDate ;
            DateTime startOfToday = day.Date;
            DateTime endOfToday = startOfToday.AddDays(1).AddTicks(-1);
            var reservations = await _unitOfWork.Reservations
            .GetByExpressionAsync(r =>
              r.PlacePrice.PlaceID == model.PlaceId &&
              r.Time >= startOfToday &&
              r.Time < endOfToday
              );
            if (reservations == null || !reservations.Any()) {
                return 0; 
            }
            int place =1;
            var userReservation = reservations.FirstOrDefault(r => r.UserID == model.UserId && r.State == Data.Enums.ReservationState.Running);
            if (userReservation != null)
            {
                place = reservations.Count(r => r.Time < userReservation.Time && r.State == Data.Enums.ReservationState.Running);
                return place;
            }
            return 0;
        }
        public async Task<Response<List<GetAllcurrentReservationDto>>> GetUsersByPlace(int placeId, PlaceType placeType)
        {
            var reservations = await _unitOfWork.Reservations
                .GetByExpressionAsync(r => r.PlacePrice.PlaceType == placeType
                                      && r.PlacePrice.PlaceID == placeId
                                      && r.State == ReservationState.Running, [r=>r.User]);
            if (!reservations.Any())
                return ResponseHandler.NotFound<List<GetAllcurrentReservationDto>>("no data ");
            List<GetAllcurrentReservationDto> ret=new List<GetAllcurrentReservationDto>();
            foreach (var reservation in reservations)
            {
                var data = new GetAllcurrentReservationDto
                {
                    firstname = reservation.User.FirstName,
                    lastname = reservation.User.LastName,
                    Nid = reservation.User.NID,
                    BirthDate= reservation.User.BirthDate,
                    SerialNumber=reservation.SerialNumber
                };
                ret.Add(data);
            }
            return ResponseHandler.Success(ret);
        }
        public async Task<PaginatedResult<List<DetailedReservation>>> GetAllReservationAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedReservation>();
            var reservations = await _unitOfWork.Reservations.GetAllFilteredAsync(filter, [d=>d.PlacePrice,d=>d.User]);

            if (!search.IsNullOrEmpty())
            {
                reservations = reservations.Where(r => r.SerialNumber.Contains(search));
            }

            if (reservations is null)
            {
                return ResponseHandler.BadRequest<List<DetailedReservation>>(pageFilter, "Reservation model is null or not found");
            }

            foreach (Reservation reservation in reservations)
            {
                var detailedReservation = new DetailedReservation()
                {
                    ID = reservation.ID,
                    Time = reservation.Time,
                    SerialNumber = reservation.SerialNumber,
                    State = reservation.State,
                    PlacePriceId = reservation.PlacePriceId,
                    UserID = reservation.UserID,
                    PlacePrice = new DetailedPlacePrice
                    {
                        ID = reservation.PlacePrice.ID,
                        Name = reservation.PlacePrice.Name,
                        Price = reservation.PlacePrice.Price,
                        PlaceID = reservation.PlacePrice.PlaceID,
                        PlaceType = reservation.PlacePrice.PlaceType
                    },
                    User = new ApplicationUser()
                    {
                        Id = reservation.User.Id,
                        FirstName = reservation.User.FirstName,
                        LastName = reservation.User.LastName,
                        NID = reservation.User.NID,
                        BirthDate = reservation.User.BirthDate,
                        BloodType = reservation.User.BloodType,
                        Gender = reservation.User.Gender,
                        Email = reservation.User.Email,
                        PhoneNumber = reservation.User.PhoneNumber,
                        MaritalStatus = reservation.User.MaritalStatus,
                    }
                };

                OutputList.Add(detailedReservation);
            }

            var count = OutputList.Count();
            var detailedReservations = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedReservations, pageFilter, count);
        }
    }
}
 