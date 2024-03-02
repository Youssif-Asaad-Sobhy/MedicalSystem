using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IReservationService
    {
        Task<Response<Reservation>> GetReservationAsync(int ID);
        Task<Response<Reservation>> DeleteReservationAsync(int ID);
        Task<Response<Reservation>> UpdateReservationAsync(UpdateReservationDto model);
        Task<Response<Reservation>> PlaceReservationAsync(PlaceReservationDto model);
        Task<Response<IEnumerable<Reservation>>> TodaysReservationsAsync();
       
        
    }
}
