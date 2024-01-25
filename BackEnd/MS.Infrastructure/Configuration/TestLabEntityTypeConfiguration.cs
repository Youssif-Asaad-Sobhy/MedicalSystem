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
    public class TestLabEntityTypeConfiguration : IEntityTypeConfiguration<TestLab>
    {
        public void Configure(EntityTypeBuilder<TestLab> builder)
        {
            builder.HasKey(testlab => testlab.ID);

            builder.HasOne(testlab => testlab.lab)
                .WithMany(lab => lab.testLabs)
                .HasForeignKey(testlab => testlab.LabID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(testlab => testlab.tests)
                .WithMany(test => test.testLabs)
                .HasForeignKey(testlab => testlab.TestID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
