using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.PlaceShift;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IPlaceShiftService
    {
        Task<Response<PlaceShift>> GetPlaceShiftAsync(int ID);
        Task<Response<PlaceShift>> DeletePlaceShiftAsync(int ID);
        Task<Response<PlaceShift>> UpdatePlaceShiftAsync(UpdatePlaceShiftDto model);
        Task<Response<PlaceShift>> CreatePlaceShiftAsync(CreatePlaceShiftDto model);
        Task<PaginatedResult<List<DetailedPlaceShift>>> GetAllPlaceShiftAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
