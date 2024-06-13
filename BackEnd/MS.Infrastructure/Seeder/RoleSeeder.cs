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
    public static class RoleSeeder
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> _roleManager)
        {
            var rolesCount =await _roleManager.Roles.CountAsync();
            if(rolesCount <= 0)
            {
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Name="Admin"
                });
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "User"
                });
            }
            if(!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "Admin"
                });
            }
            if (!await _roleManager.RoleExistsAsync("User"))
            {
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "User"
                });
            }
            if(!await _roleManager.RoleExistsAsync("Doctor"))
            {
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "Doctor"
                });
            }
            if(!await _roleManager.RoleExistsAsync("Cashier"))
            {
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "Cashier"
                });
            }


        }
    }
}
