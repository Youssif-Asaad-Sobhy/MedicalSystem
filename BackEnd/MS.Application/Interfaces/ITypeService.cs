using MS.Application.DTOs.Types;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface ITypeService
    {
        Task<Response<Types>> GetTypeAsync(int ID);
        Task<Response<Types>> DeleteTypeAsync(int ID);
        Task<Response<Types>> UpdateTypeAsync(UpdateTypeDto model);
        Task<Response<Types>> CreateTypeAsync(CreateTypeDto model);
    }
}
