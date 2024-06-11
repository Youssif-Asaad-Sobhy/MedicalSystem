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
    public class TestResultConfig : IEntityTypeConfiguration<TestResult>
    {
        public void Configure(EntityTypeBuilder<TestResult> builder)
        {
            builder.HasKey(t => t.ID);
            
            builder.HasMany(t => t.Attachments)
                .WithOne(a => a.TestResult)
                .HasForeignKey(a => a.TestResultID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
