using MS.Application.DTOs.Lab;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;
using MS.Application.DTOs.ApplicationUserDisease;

namespace MS.Application.Interfaces
{
    public interface IApplicationUserDiseaseService
    {
        Task<Response<ApplicationUserDisease>> GetApplicationUserDiseaseAsync(int ID);
        Task<Response<ApplicationUserDisease>> DeleteApplicationUserDiseaseAsync(int ID);
        Task<Response<ApplicationUserDisease>> UpdateApplicationUserDiseaseAsync(UpdateApplicationUserDiseaseDto model);
        Task<Response<ApplicationUserDiseaseDto>> CreateApplicationUserDiseaseAsync(CreateApplicationUserDiseaseDto model);
    }
}