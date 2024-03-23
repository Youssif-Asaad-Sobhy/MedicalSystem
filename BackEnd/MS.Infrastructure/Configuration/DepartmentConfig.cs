using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FluentValidation;
namespace MS.Infrastructure.Configuration
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.ID);

            builder.HasMany(d => d.Clinics)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
