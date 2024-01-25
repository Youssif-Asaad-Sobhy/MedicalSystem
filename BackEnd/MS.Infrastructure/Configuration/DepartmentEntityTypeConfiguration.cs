using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FluentValidation;
using MS.Infrastructure.Validation;
namespace MS.Infrastructure.Configuration
{
    public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.ID);
            builder.HasOne(d => d.Hospital)
                .WithMany(hospital => hospital.Departments)
                .HasForeignKey(d => d.HospitalID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
