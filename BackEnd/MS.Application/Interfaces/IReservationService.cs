using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
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
        Task<Response<IEnumerable<Reservation>>> GetUserReservationsAsync(string userId);
        Task<Response<ReservationINFODto>> GetReservationINFO(int ID);
        // i want to get the place of user in this clinic
        Task<Response<string>> GetUserPlaceInClinic(PlaceUserInClinicDto model);
    }
}
