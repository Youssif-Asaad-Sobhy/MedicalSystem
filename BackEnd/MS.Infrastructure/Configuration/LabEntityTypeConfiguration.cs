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
    public class LabEntityTypeConfiguration: IEntityTypeConfiguration<Lab>
    {
        public void Configure(EntityTypeBuilder<Lab> builder)
        {
            builder.HasKey(l => l.ID);

            builder.HasOne(lab=>lab.hospital)
                .WithMany(hospital=>hospital.Labs)
                .HasForeignKey(lab=>lab.HospitalID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
