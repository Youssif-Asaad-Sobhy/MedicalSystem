using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;
using MS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Configuration
{
    internal class PharmacyConfig : IEntityTypeConfiguration<Pharmacy>
    {
        public void Configure(EntityTypeBuilder<Pharmacy> builder)
        {
            builder.HasKey(p => p.ID);

            builder.HasMany(p => p.PharmacyMedicines)
                .WithOne(pm => pm.Pharmacy)
                .HasForeignKey(pm => pm.PharmacyID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.PlaceShifts)
                .WithOne()
                .HasForeignKey(ps => ps.EntityID)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasMany(p => p.PlaceEquipments)
               .WithOne()
               .HasForeignKey(ps => ps.EntityID)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
