using MS.Application.DTOs.ApplicationUser;
using MS.Application.DTOs.Department;
using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IApplicationUserService
    {
        Task<Response<ApplicationUser>> GetUserByIDAsync(string ID);
        Task<Response<ApplicationUser>> DeleteUserAsync(string ID);
        Task<Response<ApplicationUser>> UpdateUserAsync(UpdateUserDto model);
        Task<Response<ApplicationUser>> CreateUserAsync(CreateUserDto model);
        Task<Response<UserBasicDataDto>> GetUserDataAsync(string NID);
        Task<Response<ApplicationUser>> changePasswordAsync(ChangePasswordDto model);
        Task<Response<ApplicationUser>> ForgotPasswordAsync(ForgotPasswordDto model);
    }
}
