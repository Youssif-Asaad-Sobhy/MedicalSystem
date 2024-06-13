using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Medicine;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IMedicineService
    {
        Task<Response<Medicine>> GetMedicineAsync(int ID);
        Task<Response<Medicine>> DeleteMedicineAsync(int ID);
        Task<Response<Medicine>> UpdateMedicineAsync(UpdateMedicineDto model);
        Task<Response<Medicine>> CreateMedicineAsync(CreateMedicineDto model);
        Task<PaginatedResult<List<DetailedMedicine>>> GetAllMedicineAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
