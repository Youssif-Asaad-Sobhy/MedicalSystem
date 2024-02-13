using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            // Table name
            builder.ToTable("Hospitals");

            // Primary key
            builder.HasKey(hospital => hospital.ID);

            // Name property
            builder.Property(hospital => hospital.Name)
                .IsRequired()
                .HasMaxLength(50); // Adjust the maximum length as per your requirements

            // Phone property
            builder.Property(hospital => hospital.Phone)
                .IsRequired()
                .HasMaxLength(15) // Adjust the maximum length as per your requirements
                .HasConversion(
                    v => long.Parse(v),
                    v => v.ToString());

            // Government property
            builder.Property(hospital => hospital.Government)
                .IsRequired();

            // City property
            builder.Property(hospital => hospital.City)
                .IsRequired();

            // Country property
            builder.Property(hospital => hospital.Country)
                .IsRequired();

            // Type property
            builder.Property(hospital => hospital.Type)
                .IsRequired()
                .HasConversion<string>();

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(hospital => hospital.SomeProperty);
        }
    }
}
