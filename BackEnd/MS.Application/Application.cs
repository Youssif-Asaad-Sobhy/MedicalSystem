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
using MS.Application.Helpers.OTP;
using MS.Infrastructure.Repositories.Generics;

namespace MS.Application
{
    public static class Application
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public static  void Appplicatiion_CS(this IServiceCollection services, IConfiguration Configuration)
        {
            #region services

            services.AddScoped<ILabService,LabService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITypeService, TypeServices>();
            services.AddScoped<IShiftService, ShiftService>();
            services.AddScoped< ITestService,  TestService>();
            services.AddScoped<IClinicService, ClinicService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IAttachmentService,AttachmentService>();
            services.AddScoped<ITestLabService, TestLabService>();
            services.AddScoped<IPharmacyService,PharmacyService>();
            services.AddScoped<IMedicineService,MedicineService>();
          
            services.AddScoped<IHospitalService,HospitalService>();
            services.AddScoped<IEquipmentService,EquipmentService>();
            services.AddTransient<IMailingService, MailingService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IPlaceShiftService, PlaceShiftService>();
            services.AddScoped<IPlacePriceService, PlacePriceService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IMedicineTypeService,MedicineTypeService>();
            services.AddScoped<IApplicationUserService,ApplicationUserService>();
            services.AddScoped<IPlaceEquipmentService, PlaceEquipmentService>();
            services.AddScoped<IReportMedicineService, ReportMedicineService>();
            services.AddScoped<IPharmacyMedicineService,PharmacyMedicineService>();
            services.AddScoped(typeof(IFilter<>), typeof(FilterServices<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
           
            #endregion


            services.Configure<JwtHelper>(Configuration.GetSection("JWT"));
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<Context>()
                .AddDefaultTokenProviders()
                .AddTokenProvider<EmailTokenProvider<ApplicationUser>>(TokenOptions.DefaultEmailProvider);

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
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        //ValidIssuer = Configuration["JWT:Issuer"],
                        //ValidAudience = Configuration["JWT:Audience"],
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
