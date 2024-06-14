using MS.Application.DTOs.Lab;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;
using MS.Application.DTOs.Disease;
using MS.Application.DTOs.Clinc;
using MS.Application.Helpers.Pagination;

namespace MS.Application.Interfaces
{
    public interface IDiseaseService
    {
        Task<Response<Disease>> GetDiseaseAsync(int ID);
        Task<Response<Disease>> DeleteDiseaseAsync(int ID);
        Task<Response<Disease>> UpdateDiseaseAsync(UpdateDiseaseDto model);
        Task<Response<Disease>> CreateDiseaseAsync(CreateDiseaseDto model);
        Task<Response<List<DiseaseBasicData>>>GetAllDiseasesAsync();
        Task<PaginatedResult<List<DetailedDisease>>> GetAllDiseaseAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}