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
    internal class ReservationConfig :IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => r.ID);

            builder.HasOne(r => r.PlacePrice)
                .WithMany()
                .HasForeignKey(r => r.PlacePriceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
