using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MS.Data.Entities;
using MS.Infrastructure.Validation;

namespace MS.Infrastructure
{
    public static class Infrastructure
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            #region Validation Resolving
            services.AddTransient<IValidator<Medicine>, MedicineValidator>();
            services.AddTransient<IValidator<Types>, TypesValidator>();
            services.AddTransient<IValidator<Pharmacy>, PharmacyValidator>();
            services.AddTransient<IValidator<MedicineType>, MedicineTypeValidator>();
            services.AddTransient<IValidator<PharmacyMedicine>, PharmacyMedicineValidator>();
            services.AddTransient<IValidator<Reservation>, ReservationValidator>();
            services.AddTransient<IValidator<TestLab>, TestLabValidator>();
            services.AddTransient<IValidator<Department>, DepartmentValidator>();
            services.AddTransient<IValidator<Shift>, ShiftValidator>();
            services.AddTransient<IValidator<Clinic>, ClinicValidator>();
            services.AddTransient<IValidator<Labs>, LabsValidator>();
            services.AddTransient<IValidator<Test>, TestsValidator>();
            services.AddTransient<IValidator<Hospital>, HospitalValidator>();
            services.AddTransient<IValidator<User>, UserValidator>();
            services.AddTransient<IValidator<Report>, ReportValidator>();
            services.AddTransient<IValidator<Documents>, DocumentsValidator>();
            services.AddTransient<IValidator<ReportMedicine>, ReportMedicineValidator>();
            services.AddTransient<IValidator<Equipment>, EquipmentValidator>();
            services.AddTransient<IValidator<AttachmentDocuments>, AttachmentDocumentsValidator>();
            services.AddTransient<IValidator<PlaceEquipment>, PlaceEquipmentValidator>();
            services.AddTransient<IValidator<EntityAuth>, EntityAuthValidator>();
            services.AddTransient<IValidator<ClinicPrice>, ClinicPriceValidator>(); 
            #endregion
        }
    }
}
