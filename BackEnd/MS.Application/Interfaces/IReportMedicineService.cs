using MS.Application.DTOs.ReportMedicine;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IReportMedicineService
    {
        Task<Response<ReportMedicine>> GetReportMedicineAsync(int ID);
        Task<Response<ReportMedicine>> DeleteReportMedicineAsync(int ID);
        Task<Response<ReportMedicine>> UpdateReportMedicineAsync(UpdateReportMedicineDto model);
        Task<Response<ReportMedicine>> CreateReportMedicineAsync(CreateReportMedicineDto model);
    }
}
