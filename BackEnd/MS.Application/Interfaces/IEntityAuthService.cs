using MS.Application.DTOs.EntityAuth;
using MS.Application.DTOs.Equipment;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IEntityAuthService
    {
        Task<Response<EntityAuth>> GetEntityAuthAsync(int ID);
        Task<Response<EntityAuth>> DeleteEntityAuthAsync(int ID);
        Task<Response<EntityAuth>> UpdateEntityAuthAsync(UpdateEntityAuthDto model);
        Task<Response<EntityAuth>> CreateEntityAuthAsync(CreateEntityAuthDto model);
    }
}
