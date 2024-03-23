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
    internal class PharmacyMedicineConfig : IEntityTypeConfiguration<PharmacyMedicine>
    {
        public void Configure(EntityTypeBuilder<PharmacyMedicine> builder)
        {
            builder.HasKey(pm => pm.ID);

        }
    }
}
