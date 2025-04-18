using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Department;
using MS.Application.DTOs.Test;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface ITestService
    {
        Task<Response<Test>> GetTestAsync(int ID);
        Task<Response<Test>> DeleteTestAsync(int ID);
        Task<Response<Test>> UpdateTestAsync(UpdateTestDto model);
        Task<Response<Test>> CreateTestAsync(CreateTestDto model);
        Task<PaginatedResult<List<DetailedTest>>> GetAllTestAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
