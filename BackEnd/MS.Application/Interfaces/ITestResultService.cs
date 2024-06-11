using MS.Application.DTOs.Lab;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;
using MS.Application.DTOs.TestResult;

namespace MS.Application.Interfaces
{
    public interface ITestResultService
    {
        Task<Response<TestResult>> GetTestResultAsync(int ID);
        Task<Response<TestResult>> DeleteTestResultAsync(int ID);
        Task<Response<TestResult>> UpdateTestResultAsync(UpdateTestResultDto model);
        Task<Response<TestResult>> CreateTestResultAsync(CreateTestResultDto model);
        Task<Response<List<GetAllTestResultDto>>> GetAllTestResultAsync(string userId);
    }
}