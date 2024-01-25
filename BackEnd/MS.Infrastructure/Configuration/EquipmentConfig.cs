using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Configuration
{
    public class EquipmentConfig : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder) 
        {
            builder.HasKey(e => e.ID);

            builder.HasMany(e => e.PlaceEquipments)
                .WithOne(p => p.Equipment)
                .HasForeignKey(p => p.EquipmentID)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
