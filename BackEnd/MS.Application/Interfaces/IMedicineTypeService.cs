using MS.Application.DTOs.MedicineType;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IMedicineTypeService
    {
        Task<Response<MedicineType>> GetMedicineTypeAsync(int ID);
        Task<Response<MedicineType>> DeleteMedicineTypeAsync(int ID);
        Task<Response<MedicineType>> UpdateMedicineTypeAsync(UpdateMedicineTypeDto model);
        Task<Response<MedicineType>> CreateMedicineTypeAsync(CreateMedicineTypeDto model);
    }
}
