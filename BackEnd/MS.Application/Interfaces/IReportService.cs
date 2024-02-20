using MS.Application.DTOs.Report;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IReportService
    {
        Task<Response<Report>> GetReportAsync(int ID);
        Task<Response<Report>> DeleteReportAsync(int ID);
        Task<Response<Report>> UpdateReportAsync(UpdateReportDto model);
        Task<Response<Report>> CreateReportAsync(CreateReportDto model);
    }
}
