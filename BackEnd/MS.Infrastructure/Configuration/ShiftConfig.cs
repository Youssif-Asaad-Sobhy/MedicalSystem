using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;
using System;

namespace MS.Infrastructure.Configurations
{
    public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {
            // Table name
            builder.ToTable("Shifts");

            // Primary key
            builder.HasKey(shift => shift.ID);

            // ID property
            builder.Property(shift => shift.ID)
                .IsRequired()
            ;//    .GreaterThan(0);

            // Name property
            builder.Property(shift => shift.Name)
                .IsRequired();

            // StartTime property
            builder.Property(shift => shift.StartTime)
                .IsRequired();

            // EndTime property
            builder.Property(shift => shift.EndTime)
                .IsRequired()
                .GreaterThanOrEqualTo(shift => shift.StartTime); // Ensure EndTime is greater than or equal to StartTime

            // EntityID property
            builder.Property(shift => shift.EntityID)
                .IsRequired()
               ;// .GreaterThan(0);

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(shift => shift.SomeProperty);
        }
    }
}
