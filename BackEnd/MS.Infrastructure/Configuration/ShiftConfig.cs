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
    public class ShiftConfig: IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {
            builder.HasKey(s => s.ID);

            builder.HasMany(s => s.PlaceShifts)
                .WithOne(ps => ps.Shift)
                .HasForeignKey(ps => ps.ShiftID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
