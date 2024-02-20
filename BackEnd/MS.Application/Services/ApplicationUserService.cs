﻿using Microsoft.AspNetCore.Identity;
using MS.Application.DTOs.ApplicationUser;
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
    public class ApplicationUserService: IApplicationService
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
                Name=model.Name,
                Email=model.Email,
                PhoneNumber=model.Phone,
                NID=model.NID,
                Gender=model.Gender,
                BirthDate=model.BirthDate
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
            user.Email = model.Email;
            user.Name = model.Name;
            user.PhoneNumber = model.Phone;
            user.NID = model.NID;
            user.Gender = model.Gender;
            user.BirthDate = model.BirthDate;
            await _userManager.UpdateAsync(user);
            return ResponseHandler.Success(user);
        }
    }
}