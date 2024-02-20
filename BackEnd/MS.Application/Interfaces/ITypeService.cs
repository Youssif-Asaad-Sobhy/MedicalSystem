using MS.Application.DTOs.Type;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface ITypeService
    {
        Task<Response<Type>> GetTypeAsync(int ID);
        Task<Response<Type>> DeleteTypeAsync(int ID);
        Task<Response<Type>> UpdateTypeAsync(UpdateTypeDto model);
        Task<Response<Type>> CreateTypeAsync(CreateTypeDto model);
    }
}
