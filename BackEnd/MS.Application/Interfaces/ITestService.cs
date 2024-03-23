using MS.Application.DTOs.Department;
using MS.Application.DTOs.Test;
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
    }
}
