using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            // Table name
            builder.ToTable("Equipments");

            // Primary key
            builder.HasKey(equipment => equipment.ID);

            // Name property
            builder.Property(equipment => equipment.Name)
                .IsRequired()
                .HasMaxLength(50); // Adjust the maximum length as per your requirements

            // Description property
            builder.Property(equipment => equipment.Description)
                .IsRequired()
                .HasMaxLength(200); // Adjust the maximum length as per your requirements

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(equipment => equipment.SomeProperty);
        }
    }
}
