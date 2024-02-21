using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MS.Infrastructure.Contexts;
using System.Text;
using MS.Application.Helpers;
using MS.Data.Entities;
using MS.Application.Interfaces;
using MS.Application.Services;
using Microsoft.EntityFrameworkCore;
using MediatR;
using MS.Application.Helpers.ValidationHelper;
using System.Reflection;
using FluentValidation;

namespace MS.Application
{
    public static class Application
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public static  void Appplicatiion_CS(this IServiceCollection services, IConfiguration Configuration)
        {

            services.Configure<JwtHelper>(Configuration.GetSection("JWT"));

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<Context>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IClinicService, ClinicService>();
            services.AddScoped<IClinicPriceService, ClinicPriceService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDocumentService,DocumentService>();
            services.AddScoped<IApplicationService,ApplicationUserService>();

            services.AddScoped<IPlaceEquipmentService, PlaceEquipmentService>();
            services.AddScoped<IPlaceShiftService, PlaceShiftService>();
            services.AddScoped<IReportMedicineService, ReportMedicineService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IShiftService, ShiftService>();
            services.AddScoped<ITestLabService, TestLabService>();
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<ITypeService, TypeServices>();



            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.RequireHttpsMetadata = false;
                    o.SaveToken = false;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = Configuration["JWT:Issuer"],
                        ValidAudience = Configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Key"]))
                    };
                });
            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }

    }
}
