using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Configuration
{
    internal class ClinicEntityTypeConfiguration : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.HasKey(c => c.ID);

            builder.HasOne(clinic => clinic.department)
                    .WithOne()
                    .HasForeignKey<Clinic>(c=>c.DepartmentID)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
