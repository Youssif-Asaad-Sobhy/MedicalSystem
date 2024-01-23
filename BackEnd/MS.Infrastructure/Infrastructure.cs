using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MS.Data.Entities;
using MS.Infrastructure.Validation;

namespace MS.Infrastructure
{
    public class Infrastructure
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IValidator<Medicine>, MedicineValidator>();
        }
    }
}
