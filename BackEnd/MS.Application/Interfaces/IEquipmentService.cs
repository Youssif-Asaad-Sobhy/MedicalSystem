using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Equipment;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IEquipmentService
    {
        Task<Response<Equipment>> GetEquipmentAsync(int ID);
        Task<Response<Equipment>> DeleteEquipmentAsync(int ID);
        Task<Response<Equipment>> UpdateEquipmentAsync(UpdateEquipmentDto model);
        Task<Response<Equipment>> CreateEquipmentAsync(CreateEquipmentDto model);
        Task<PaginatedResult<List<DetailedEquipment>>> GetAllEquipmentAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
