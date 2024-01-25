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
    public class LabConfig: IEntityTypeConfiguration<Lab>
    {
        public void Configure(EntityTypeBuilder<Lab> builder)
        {
            builder.HasKey(l => l.ID);

            builder.HasOne(lab=>lab.hospital)
                .WithMany(hospital=>hospital.Labs)
                .HasForeignKey(lab=>lab.HospitalID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(l => l.PlaceShifts)
                .WithOne()
                .HasForeignKey(ps => ps.EntityID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.PlaceEquipment)
               .WithOne()
               .HasForeignKey(ps => ps.EntityID)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(l => l.Reservations)
               .WithOne()
               .HasForeignKey(r => r.EntityID)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
