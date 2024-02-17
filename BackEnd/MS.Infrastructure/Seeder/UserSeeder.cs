using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Seeder
{
    public static class UserSeeder
    {
        public static async Task SeedAsync(UserManager<ApplicationUser>_userManager)
        {
            var usersCount=await _userManager.Users.CountAsync();
            if(usersCount <= 0) 
            {
                var defaultuser = new ApplicationUser()
                {
                    Name = "admin user",
                    NID = "52153315053",
                    Gender = "Male",
                    BirthDate = new DateTime(2002, 9, 25)
                };
                await _userManager.CreateAsync(defaultuser,"M123_m");
                await _userManager.AddToRoleAsync(defaultuser, "Admin");         
            }
        }
    }
}
