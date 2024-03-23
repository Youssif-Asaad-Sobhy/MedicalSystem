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
    internal class MedicineConfig : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.HasKey(m => m.ID);

            builder.HasMany(m => m.MedicineTypes)
                .WithOne(mt => mt.Medicine)
                .HasForeignKey(mt => mt.MedicineID)
                .OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
