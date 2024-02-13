using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;
using System;

namespace MS.Infrastructure.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            // Table name
            builder.ToTable("Reservations");

            // Primary key
            builder.HasKey(reservation => reservation.ID);

            // ID property
            builder.Property(reservation => reservation.ID)
                .IsRequired()
              ;//  .GreaterThan(0);

            // Time property
            builder.Property(reservation => reservation.Time)
                .IsRequired()
                .Must(BeInTheFuture); // Custom validation for time being in the future

            // UserID property
            builder.Property(reservation => reservation.UserID)
                .IsRequired();

            // State property
            builder.Property(reservation => reservation.State)
                .IsRequired();

            // PlaceType property
            builder.Property(reservation => reservation.PlaceType)
                .IsRequired();

            // EntityID property
            builder.Property(reservation => reservation.EntityID)
                .IsRequired()
        ;//        .GreaterThan(0);

            // Price property
            builder.Property(reservation => reservation.Price)
                .IsRequired()
           ;//     .GreaterThanOrEqualTo(0); // Ensure price is non-negative

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(reservation => reservation.SomeProperty);
        }

        // Custom validation method to check if the reservation time is in the future
        private bool BeInTheFuture(DateTime time)
        {
            return time > DateTime.Now;
        }
    }
}
