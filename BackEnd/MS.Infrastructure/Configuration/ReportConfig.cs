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
    public class ReportConfig : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report>builder)
        {
            builder.HasKey(r => r.ID);

            builder.HasMany(r=>r.ReportMedicines)
                .WithOne(rm=>rm.Report)
                .HasForeignKey(rm=>rm.ReportID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
