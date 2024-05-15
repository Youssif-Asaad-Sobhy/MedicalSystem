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
    public class DiseaseConfig: IEntityTypeConfiguration<Disease>
    {
        public void Configure(EntityTypeBuilder<Disease> builder)
        {
            builder.HasKey(d => d.ID);
            builder.HasMany(d => d.UserDiseases)
                .WithOne(ud => ud.Disease)
                .HasForeignKey(ud => ud.DiseaseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Description).HasMaxLength(500);
        }
    }
}
