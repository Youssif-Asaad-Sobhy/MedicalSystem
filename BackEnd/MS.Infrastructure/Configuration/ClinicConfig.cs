using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class ClinicConfiguration : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            // Table name
            builder.ToTable("Clinics");

            // Primary key
            builder.HasKey(c => c.ID);

            // Name property
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255); // Adjust the maximum length as per your requirements

            // DepartmentID property
            builder.Property(c => c.DepartmentID)
                .IsRequired();

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(c => c.SomeProperty);
        }
    }
}
