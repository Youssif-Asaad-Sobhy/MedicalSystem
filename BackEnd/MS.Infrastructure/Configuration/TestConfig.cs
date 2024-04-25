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
    public class TestConfig: IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(t => t.ID);
            // i want t add cnfig for a relashionship between test and document 
            builder.HasOne(t => t.Photo)
                .WithOne()
                .HasForeignKey<Test>(t => t.PhotoID);
        }
    }
}
