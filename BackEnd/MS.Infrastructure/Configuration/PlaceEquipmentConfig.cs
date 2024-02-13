using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class PlaceEquipmentConfiguration : IEntityTypeConfiguration<PlaceEquipment>
    {
        public void Configure(EntityTypeBuilder<PlaceEquipment> builder)
        {
            // Table name
            builder.ToTable("PlaceEquipments");

            // Primary key
            builder.HasKey(pe => pe.ID);

            // EquipmentID property
            builder.Property(pe => pe.EquipmentID)
                .IsRequired();

            // EntityID property
            builder.Property(pe => pe.EntityID)
                .IsRequired();

            // PlaceType property
            builder.Property(pe => pe.PlaceType)
                .IsRequired()
                .HasMaxLength(50); // Adjust the maximum length as per your requirements

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(pe => pe.SomeProperty);
        }
    }
}
