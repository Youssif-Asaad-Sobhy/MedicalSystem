using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class ClinicPriceConfiguration : IEntityTypeConfiguration<ClinicPrice>
    {
        public void Configure(EntityTypeBuilder<ClinicPrice> builder)
        {
            // Table name
            builder.ToTable("ClinicPrices");

            // Primary key
            builder.HasKey(cp => cp.ID);

            // Name property
            builder.Property(cp => cp.Name)
                .IsRequired()
                .HasMaxLength(255);// Adjust the maximum length as per your requirements

            // Price property
            builder.Property(cp => cp.Price)
                .IsRequired()
                .HasColumnType("decimal(18, 2)") // Adjust the precision and scale as per your requirements
                .HasDefaultValue(0); // Example default value, adjust as needed

            // ClinicID property
            builder.Property(cp => cp.ClinicID)
                .IsRequired();

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(cp => cp.SomeProperty);
        }
    }
}
