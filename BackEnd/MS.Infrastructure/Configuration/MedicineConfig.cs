using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            // Table name
            builder.ToTable("Medicines");

            // Primary key
            builder.HasKey(medicine => medicine.ID);

            // Name property
            builder.Property(medicine => medicine.Name)
                .IsRequired()
                .HasMaxLength(50); // Adjust the maximum length as per your requirements

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(medicine => medicine.SomeProperty);
        }
    }
}
