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
    public class MedicineTypeConfig : IEntityTypeConfiguration<MedicineType>
    {
        public void Configure(EntityTypeBuilder<MedicineType> builder)
        {
            builder.HasKey(mt => mt.ID);

            builder.HasMany(mt => mt.PharmacyMedicines)
                .WithOne(pm => pm.MedicineType)
                .HasForeignKey(pm => pm.MedicineTypeID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(mt => mt.ReportMedicines)
                .WithOne(rm => rm.MedicineType)
                .HasForeignKey(rm => rm.MedicineTypeID)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
