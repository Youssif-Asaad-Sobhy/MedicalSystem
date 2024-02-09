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

            builder.HasMany(l => l.TestLabs)
                .WithOne(tl=>tl.Lab)
                .HasForeignKey(tl => tl.LabID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(l => l.PlaceShifts)
                .WithOne()
                .HasForeignKey(ps => ps.EntityID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.PlaceEquipments)
               .WithOne()
               .HasForeignKey(ps => ps.EntityID)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(l => l.Reservations)
               .WithOne()
               .HasForeignKey(r => r.EntityID)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
