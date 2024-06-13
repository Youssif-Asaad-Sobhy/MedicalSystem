using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.TestLab;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface ITestLabService
    {
        Task<Response<TestLab>> GetTestLabAsync(int ID);
        Task<Response<TestLab>> DeleteTestLabAsync(int ID);
        Task<Response<TestLab>> UpdateTestLabAsync(UpdateTestLabDto model);
        Task<Response<TestLab>> CreateTestLabAsync(CreateTestLabDto model);
        Task<Response<List<AllTestDto>>> GetTestListAsync();
        Task<PaginatedResult<List<DetailedTestLab>>> GetAllTestLabAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
