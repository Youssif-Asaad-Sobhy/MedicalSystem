using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Hospital;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IHospitalService
    {
        Task<Response<Hospital>> GetHospitalAsync(int ID);
        Task<Response<Hospital>> DeleteHospitalAsync(int ID);
        Task<Response<Hospital>> UpdateHospitalAsync(UpdateHospitalDto model);
        Task<Response<Hospital>> CreateHospitalAsync(CreateHospitalDto model);
        Task<PaginatedResult<List<DetailedHospital>>> GetAllHospitalAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
