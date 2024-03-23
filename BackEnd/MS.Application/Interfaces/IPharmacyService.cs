using MS.Application.DTOs.Pharmacy;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IPharmacyService
    {
        Task<Response<Pharmacy>> GetPharmacyAsync(int ID);
        Task<Response<Pharmacy>> DeletePharmacyAsync(int ID);
        Task<Response<Pharmacy>> UpdatePharmacyAsync(UpdatePharmacyDto model);
        Task<Response<Pharmacy>> CreatePharmacyAsync(CreatePharmacyDto model);
    }
}
