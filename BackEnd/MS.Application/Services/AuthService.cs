﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MS.Application.Helpers;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Models.Authentication;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtHelper _jwt;

        public AuthService(IUnitOfWork unitOfWork,UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<JwtHelper> jwt)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _jwt = jwt.Value;
            _roleManager = roleManager;
        }
        public async Task<string> AddRoleAsync(AddRoleDto model)
        {
            var user = await _userManager.FindByIdAsync(model.Userid);
            if (user == null || !await _roleManager.RoleExistsAsync(model.RoleName))
                return "Invalid user ID or Role";
            if (await _userManager.IsInRoleAsync(user, model.RoleName))
                return "Role is already assigned to this user";
            var result = await _userManager.AddToRoleAsync(user, model.RoleName);
            return result.Succeeded ? string.Empty : "Something Went Wrong";
        }

        public async Task<AuthDto> GetTokenAsync(TokenRequestDto model)
        {
            var authmodel = new AuthDto();
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user is null || (!await _userManager.CheckPasswordAsync(user, model.Password)))
            {
                authmodel.Description = "Email or pass is incorrect";
                return authmodel;
            }
            var JwtSecurityToken = await CreateJwtToken(user);
            authmodel.IsAuthenticted = true;
            authmodel.Name = user.Name;
            authmodel.NID = user.NID;
            authmodel.Email = user.Email;
            authmodel.Username = user.UserName;
            authmodel.ExpiresOn = JwtSecurityToken.ValidTo;
            authmodel.Token = new JwtSecurityTokenHandler().WriteToken(JwtSecurityToken);

            var roleslist = await _userManager.GetRolesAsync(user);
            authmodel.Roles = roleslist.ToList();
            return authmodel;
        }

        public async Task<AuthDto> RegisterAsync(RegisterDto model)
        {
            if (await _userManager.FindByEmailAsync(model.Email) is not null)
                return new AuthDto { Description = "email is already Register" };
            if (string.IsNullOrEmpty(model.Username))
                model.Username = model.Name;
            if (await _userManager.FindByNameAsync(model.Username) is not null)
                return new AuthDto { Description = "UserName is already Register" };
            // make validation for nid thatbe unique 
            if (await _unitOfWork.Users.GetByExpressionAsync(u => u.NID == model.NID) is not null)
                return new AuthDto { Description = "National ID is already register" };


            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                Name = model.Name,
                Gender = model.Gender,
                NID = model.NID,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                var errors = string.Empty;
                foreach (var error in result.Errors)
                {
                    errors += $"{error.Description}, ";
                }
                return new AuthDto { Description = errors };
            }
            await _userManager.AddToRoleAsync(user, "User");
            var JwtSecurityToken = await CreateJwtToken(user);
            return new AuthDto
            {
                Email = user.Email,
                ExpiresOn = JwtSecurityToken.ValidTo,
                IsAuthenticted = true,
                Roles = new List<string> { "User" },
                Token = new JwtSecurityTokenHandler().WriteToken(JwtSecurityToken),
                Username = user.UserName,
            };
        }
        private async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>();

            foreach (var role in roles)
                roleClaims.Add(new Claim("roles", role));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            List<string> audiences = new List<string>(_jwt.ValidAudience);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.ValidIssuer,
                audience: audiences.ToString(),
                claims: claims,
                expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }
    }
}
