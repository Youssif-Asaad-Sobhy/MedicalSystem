using MS.Application.Helpers.Response;
using MS.Application.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IAuthService
    {
        Task<Response<AuthDto>> RegisterAsync(RegisterDto model);
        Task<Response<AuthDto>> GetTokenAsync(TokenRequestDto model);
        Task<Response<string>> AddRoleAsync(AddRoleDto model);
    }
}
