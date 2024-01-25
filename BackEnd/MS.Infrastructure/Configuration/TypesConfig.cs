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
    internal class TypesConfig : IEntityTypeConfiguration<Types>
    {
        public void Configure(EntityTypeBuilder<Types> builder)
        {
            builder.HasKey(t => t.ID);

            builder.HasMany(t=>t.MedicineTypes)
                .WithOne(mt=>mt.Types)
                .HasForeignKey(mt=>mt.TypeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
