using Microsoft.AspNetCore.Identity;
using MS.Application.DTOs.ApplicationUser;
using MS.Application.DTOs.Report;
using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Pagination;
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
        private readonly IAttachmentService _attachmentService;

        public ApplicationUserService(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,IAttachmentService attachmentService)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _attachmentService = attachmentService;
        }

        public async Task<Response<ApplicationUser>> CreateUserAsync(CreateUserDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<ApplicationUser>($"User model not found.");
            }
            var user = new ApplicationUser()
            {
                Id = model.NID,
                UserName= model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.Phone,
                NID = model.NID,
                Gender = model.Gender,
                BirthDate = new DateTime(model.BirthDate, new TimeOnly()),
                IsRegister=true,
                BloodType=model.BloodType,
                MaritalStatus=model.MaritalStatus
            };
            try
            {
                var u = await _userManager.CreateAsync(user);
                if (!u.Succeeded)
                {
                    return ResponseHandler.BadRequest<ApplicationUser>(string.Join(", ", u.Errors.Select(error => error.Description)));
                }
                await _userManager.AddToRolesAsync(user, model.Roles);
                return ResponseHandler.Created(user);
            }
            catch (Exception e)
            {
                string s = e.InnerException.Message;
                return ResponseHandler.BadRequest<ApplicationUser>(s);
            }
        }

        public async Task<Response<ApplicationUser>> DeleteUserAsync(string ID)
        {
            var user = await _userManager.FindByIdAsync(ID);
            if (user is null || ID == null)
            {
                return ResponseHandler.BadRequest<ApplicationUser>("User model is null or not found");
            }
            await _userManager.DeleteAsync(user);
            return ResponseHandler.Deleted<ApplicationUser>();
        }

        public async Task<Response<ApplicationUserDto>> GetUserByIDAsync(string ID)
        {
            var user = await _userManager.FindByIdAsync(ID);
            if (user is null || ID == null)
            {
                return ResponseHandler.BadRequest<ApplicationUserDto>("User model is null or not found");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var dto = new ApplicationUserDto()
            {
                ID = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                NID = user.NID,
                BirthDate = user.BirthDate,
                Gender = user.Gender,
                IsRegister = user.IsRegister,
                BloodType = user.BloodType,
                MaritalStatus = user.MaritalStatus,
                Roles = roles
            };
            return ResponseHandler.Success(dto);
        }

        public async Task<Response<ApplicationUser>> UpdateUserAsync(UpdateUserDto model)
        {
            var user = await _userManager.FindByIdAsync(model.ID);
            if (user is null || model.ID == null)
            {
                return ResponseHandler.BadRequest<ApplicationUser>("User model is null or not found");
            }
            user.FirstName = model.FirstName !="" ? model.FirstName : user.FirstName;
            user.LastName = model.LastName != "" ? model.LastName: user.LastName;
            user.Email = model.Email != "" ? model.Email : user.Email;
            user.PhoneNumber = model.Phone != "" ? model.Phone :user.PhoneNumber ;
            user.NID = model.NID != "" ? model.NID : user.NID;
            user.Gender = model.Gender != "" ? model.Gender:user.Gender;
            user.BirthDate = model.BirthDate != null ?model.BirthDate:user.BirthDate;
            user.BloodType = model.BloodType != "" ? model.BloodType:user.BloodType;
            user.MaritalStatus = model.MaritalStatus != "" ? model.MaritalStatus:user.MaritalStatus;
            await _userManager.RemoveFromRolesAsync(user, await _userManager.GetRolesAsync(user));
            await _userManager.AddToRolesAsync(user, model.Roles);
            await _userManager.UpdateAsync(user);
            return ResponseHandler.Success(user);
        }
        public async Task<Response<UserBasicDataDto>> GetUserDataAsync(string NID)
        {
            var user = await _unitOfWork.Users.GetByExpressionSingleAsync(u=>u.Id==NID);
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
                BloodType = user.BloodType
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

        public async Task<Response<List<UserDiseasesDto>>> GetAllUserDiseases(string id)
        {
            var user= await _unitOfWork.Users.GetByExpressionSingleAsync(u=>u.Id==id, [u=>u.UserDiseases]);
            List<UserDiseasesDto> userDisease = new List<UserDiseasesDto>();
            foreach (var UserDiseases in user.UserDiseases)
            {
                var x = await _unitOfWork.ApplicationUserDiseases.
                    GetByExpressionSingleAsync(ud => ud.ID == UserDiseases.ID, [ud => ud.Disease, ud => ud.Attachments]);
                #region Mapping
                UserDiseasesDto dto = new UserDiseasesDto()
                {
                    MaritalStatus = user.MaritalStatus,
                    Gender = user.Gender,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Type = x.Type,
                    ValueResult = x.ValueResult,
                    Description = x.Description,
                    Height = x.Height,
                    Weight = x.Weight,
                    DiseaseName = x.Disease?.Name,
                    DiseaseDescription = x.Disease?.Description,
                    DiseaseCauses = x.Disease?.Causes,
                    DiseaseSymptoms = x.Disease?.Symptoms,
                    Diagnosis = x.Diagnosis,
                    DiagnosisDate = x.DiagnosisDate,
                    DocViewUrl = []
                };
                 

                var atts = new List<string>();
                if (x.Attachments == null)
                {
                    dto.DocViewUrl = null;
                }
                else
                {
                    foreach(var attachment in x.Attachments)
                    {
                        if (attachment != null)
                        {
                            atts.Add(attachment.ViewUrl);
                        }
                    }
                    dto.DocViewUrl = atts;
                    //dto.DocViewUrl.AddRange(atts);
                }
                #endregion
                userDisease.Add(dto);
            }
            if (userDisease.Count == 0)
            {
                return ResponseHandler.Success<List<UserDiseasesDto>>("No Data Found");
            }
            return ResponseHandler.Success(userDisease);
        }
        public async Task<PaginatedResult<List<UserDto>>> GetAllUsers(PageFilter filter,string search=null)
        {
            var dto = new List<UserDto>();
            if (search == null) search = "";
            var users = await _unitOfWork.Users.GetByExpressionAsync(
                (filter.PageNumber - 1) * filter.PageSize, filter.PageSize,
                x =>x.Id.Contains(search) || 
                x.NID.Contains(search) || 
                x.FirstName.Contains(search) || 
                x.LastName.Contains(search) || 
                x.Email.Contains(search));
            var countRecord = await _unitOfWork.Users.CountAsync(
                x => x.Id.Contains(search) ||
                x.NID.Contains(search) ||
                x.FirstName.Contains(search) ||
                x.LastName.Contains(search) ||
                x.Email.Contains(search));
            foreach (var user in users)
            {
                dto.Add(new UserDto{
                    ID = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    NID = user.NID
                });
            }
            return ResponseHandler.Success(dto,filter,countRecord);
        }
    }
}
