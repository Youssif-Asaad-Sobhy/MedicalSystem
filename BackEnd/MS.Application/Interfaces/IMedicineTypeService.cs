using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.MedicineType;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;
using MS.Application.DTOs.Medicine;

namespace MS.Application.Interfaces
{
    public interface IMedicineTypeService
    {
        Task<Response<MedicineType>> GetMedicineTypeAsync(int ID);
        Task<Response<MedicineType>> DeleteMedicineTypeAsync(int ID);
        Task<Response<MedicineType>> UpdateMedicineTypeAsync(UpdateMedicineTypeDto model);
        Task<Response<MedicineType>> CreateMedicineTypeAsync(CreateMedicineTypeDto model);
        Task<PaginatedResult<List<DetailedMedicineType>>> GetAllMedicineTypeAsync(string[]? filter, PageFilter? pageFilter, string? search = null);
        Task<PaginatedResult<List<DetailedMedicineType>>> GetMedicineByIDAsync(int id, string[]? filter, PageFilter? pageFilter, string? search = null);
        Task<Response<AddMedicineTypeDto>> AddMedicineAsync(AddMedicineTypeDto model);
    }
}
