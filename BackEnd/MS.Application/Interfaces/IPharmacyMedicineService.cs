using MS.Application.DTOs.PharmacyMedicine;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IPharmacyMedicineService
    {
        Task<Response<PharmacyMedicine>> GetPharmacyMedicineAsync(int ID);
        Task<Response<PharmacyMedicine>> DeletePharmacyMedicineAsync(int ID);
        Task<Response<PharmacyMedicine>> UpdatePharmacyMedicineAsync(UpdatePharmacyMedicineDto model);
        Task<Response<PharmacyMedicine>> CreatePharmacyMedicineAsync(CreatePharmacyMedicineDto model);
    }
}
