using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Helpers.UserManagerExtensions
{
    public static class UserManagerExtensions
    {
        public static string GetCurrentUserId<TUser>(this UserManager<TUser> userManager, IHttpContextAccessor httpContextAccessor) where TUser : class
        {
            var userId = httpContextAccessor.HttpContext.User.FindFirst("uid")?.Value;
            if (userId is null)
            {
                throw new UnauthorizedAccessException();
            }
            return userId;
        }

    }
}
