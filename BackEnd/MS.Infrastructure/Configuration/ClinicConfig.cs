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
    internal class ClinicConfig : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.HasKey(c => c.ID);

            builder.HasMany(c => c.PlaceShifts)
                .WithOne()
                .HasForeignKey(ps => ps.EntityID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.ClinicPrices)
                .WithOne(c => c.Clinic)
                .HasForeignKey(c => c.ClinicID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.PlaceEquipment)
               .WithOne()
               .HasForeignKey(ps => ps.EntityID)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Reservations)
               .WithOne()
               .HasForeignKey(r => r.EntityID)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
