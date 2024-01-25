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
    public class TestLabConfig : IEntityTypeConfiguration<TestLab>
    {
        public void Configure(EntityTypeBuilder<TestLab> builder)
        {
            builder.HasKey(testlab => testlab.ID);

            builder.HasOne(testlab => testlab.Test)
                .WithMany(test => test.TestLabs)
                .HasForeignKey(testlab => testlab.TestLabID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
