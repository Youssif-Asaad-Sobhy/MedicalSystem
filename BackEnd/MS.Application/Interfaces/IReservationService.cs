using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using MS.Data.Enums;
using MS.Infrastructure.Repositories.Dtos;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IReservationService
    {
        Task<Response<Reservation>> GetReservationAsync(int ID);
        Task<Response<Reservation>> DeleteReservationAsync(int ID);
        Task<Response<Reservation>> UpdateReservationAsync(UpdateReservationDto model);
        Task<Response<ReservationDto>> PlaceReservationAsync(PlaceReservationDto model);
        Task<PaginatedResult<IEnumerable<Reservation>>> TodaysReservationsAsync(PageFilter filter);
        Task<Response<List<UserReservationDetails>>> GetUserReservationsAsync(string userId);
        Task<ReservationINFODto> GetReservationINFO(int id);
        // i want to get the place of user in this clinic
        Task<int> GetUserPlaceInClinic(PlaceUserInClinicDto model);
        Task<Response<List<GetAllcurrentReservationDto>>> GetUsersByPlace(int placeId, PlaceType placeType);
        Task<PaginatedResult<List<DetailedReservation>>> GetAllReservatoinAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
