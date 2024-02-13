using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class LabConfiguration : IEntityTypeConfiguration<Lab>
    {
        public void Configure(EntityTypeBuilder<Lab> builder)
        {
            // Table name
            builder.ToTable("Labs");

            // Primary key
            builder.HasKey(lab => lab.ID);

            // Name property
            builder.Property(lab => lab.Name)
                .IsRequired()
                .HasMaxLength(50); // Adjust the maximum length as per your requirements

            // Type property
            builder.Property(lab => lab.Type)
                .IsRequired()
                .HasConversion<string>(); // Convert enum to string for database storage

            // HospitalID property
            builder.Property(lab => lab.HospitalID)
                .IsRequired();
            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(lab => lab.SomeProperty);
        }
    }
}
