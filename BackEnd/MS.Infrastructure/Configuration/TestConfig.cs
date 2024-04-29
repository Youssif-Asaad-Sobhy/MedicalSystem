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
           
            builder.HasOne(t => t.Photo)
                .WithOne(a=>a.Test)
                .HasForeignKey<Test>(t => t.PhotoID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
