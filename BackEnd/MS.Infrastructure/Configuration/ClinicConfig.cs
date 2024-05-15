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

            builder.HasOne(c => c.Photo)
                .WithOne(a=>a.Clinic)
                .HasForeignKey<Clinic>(c => c.PhotoID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(c => c.PlacePrices)
                .WithOne()
                .HasForeignKey(c => c.PlaceID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.PlaceEquipment)
               .WithOne()
               .HasForeignKey(ps => ps.EntityID)
               .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasMany(c => c.PlaceShifts)
                .WithOne()
                .HasForeignKey(ps => ps.EntityID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
