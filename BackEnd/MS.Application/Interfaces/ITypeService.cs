using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Type;
using MS.Application.DTOs.Types;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface ITypeService
    {
        Task<Response<Types>> GetTypeAsync(int ID);
        Task<Response<Types>> DeleteTypeAsync(int ID);
        Task<Response<Types>> UpdateTypeAsync(UpdateTypeDto model);
        Task<Response<Types>> CreateTypeAsync(CreateTypeDto model);
        Task<PaginatedResult<List<DetailedType>>> GetAllTypeAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
