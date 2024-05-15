using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MS.Data.Entities;
using MS.Infrastructure.Contexts;
using MS.Infrastructure.Repositories.Generics;
using MS.Infrastructure.Repositories.Repository.RepoClasses;
using MS.Infrastructure.Repositories.Repository.RepoInterfaces;
using MS.Infrastructure.Repositories.UnitOfWork;
namespace MS.Infrastructure
{
    public static class Infrastructure
    {

        public static void Infrastructure_CS(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<IUnitOfWork,UnitOfWork>();
            services.AddScoped<IResrvationRepo, ReservationRepo>();
            services.AddDbContext<Context>(
                options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                });
        }
    }
}
