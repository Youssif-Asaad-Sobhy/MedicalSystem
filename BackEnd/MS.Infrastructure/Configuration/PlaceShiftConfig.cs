using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class PlaceShiftConfiguration : IEntityTypeConfiguration<PlaceShift>
    {
        public void Configure(EntityTypeBuilder<PlaceShift> builder)
        {
            // Table name
            builder.ToTable("PlaceShifts");

            // Primary key
            builder.HasKey(placeShift => placeShift.ID);

            // ID property
            builder.Property(placeShift => placeShift.ID)
                .IsRequired()
                .GreaterThan(0);

            // EntityID property
            builder.Property(placeShift => placeShift.EntityID)
                .IsRequired()
                .GreaterThan(0);

            // PlaceType property
            builder.Property(placeShift => placeShift.PlaceType)
                .IsRequired();

            // ShiftID property
            builder.Property(placeShift => placeShift.ShiftID)
                .IsRequired();

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(placeShift => placeShift.SomeProperty);
        }
    }
}
