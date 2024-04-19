using Microsoft.AspNetCore.Identity;
using MS.Application.DTOs.ApplicationUser;
using MS.Application.DTOs.Report;
using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Services
{
    public class ApplicationUserService: IApplicationUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<Response<ApplicationUser>> CreateUserAsync(CreateUserDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<ApplicationUser>($"User model not found.");
            }
            var user = new ApplicationUser()
            {
                Id=model.NID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email=model.Email,
                PhoneNumber=model.Phone,
                NID=model.NID,
                Gender=model.Gender,
                BirthDate=model.BirthDate,
                IsRegister=true,
            };
            await _unitOfWork.Users.AddAsync(user);
            return ResponseHandler.Created(user);
        }

        public async Task<Response<ApplicationUser>> DeleteUserAsync(string ID)
        {
            var user = await _userManager.FindByIdAsync(ID);
            if (user is null || ID == null)
            {
                return ResponseHandler.BadRequest<ApplicationUser>("User model is null or not found");
            }
            await _unitOfWork.Users.DeleteAsync(user);
            return ResponseHandler.Deleted<ApplicationUser>();
        }

        public async Task<Response<ApplicationUser>> GetUserByIDAsync(string ID)
        {
            var user = await _userManager.FindByIdAsync(ID);
            if (user is null || ID == null)
            {
                return ResponseHandler.BadRequest<ApplicationUser>("User model is null or not found");
            }
            return ResponseHandler.Success(user);
        }

        public async Task<Response<ApplicationUser>> UpdateUserAsync(UpdateUserDto model)
        {
            var user = await _userManager.FindByIdAsync(model.ID);
            if (user is null || model.ID == null)
            {
                return ResponseHandler.BadRequest<ApplicationUser>("User model is null or not found");
            }
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.PhoneNumber = model.Phone;
            user.NID = model.NID;
            user.Gender = model.Gender;
            user.BirthDate = model.BirthDate;
            await _userManager.UpdateAsync(user);
            return ResponseHandler.Success(user);
        }
        public async Task<Response<UserBasicDataDto>> GetUserDataAsync(string NID)
        {
            var user = await _unitOfWork.Users.GetByExpressionSingleAsync(u=>u.Id==NID, [u=>u.Reports]);
            if (user is null)
            {
                return ResponseHandler.BadRequest<UserBasicDataDto>("user is null");
            }
            var data = new UserBasicDataDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                NID = user.NID,
                report = user.Reports.Select(r => new ReportDto()
                {
                    ID = r.ID,
                    Time = r.Time,
                    Description = r.Description
                }).ToList() 

            };
            return ResponseHandler.Success(data);
        }

        public async Task<Response<ApplicationUser>> changePasswordAsync(ChangePasswordDto model)
        {
            if (model.OldPassword == model.NewPassword)
            {
                return ResponseHandler.BadRequest<ApplicationUser>("can you please choose a new password");
            }
            var currentuser = await _userManager.FindByNameAsync(model.UserName);
            if (currentuser == null) { return ResponseHandler.NotFound<ApplicationUser>(); }
            var res=await _userManager.ChangePasswordAsync(currentuser,model.OldPassword,model.NewPassword);
            if (!res.Succeeded)
            {
                return ResponseHandler.BadRequest<ApplicationUser>
                    (string.Join(", ", res.Errors.Select(error => error.Description)));
            }
            return ResponseHandler.Success<ApplicationUser>("password has been changed");
        }

        public async Task<Response<ApplicationUser>> ForgotPasswordAsync(ForgotPasswordDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return ResponseHandler.NotFound<ApplicationUser>();
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);
            if (!result.Succeeded)
            {
                var errorMessage = string.Join(", ", result.Errors.Select(error => error.Description));
                return ResponseHandler.BadRequest<ApplicationUser>(errorMessage);
            }
            return ResponseHandler.Success<ApplicationUser>("Password reset successfully");
        }
    }
}
