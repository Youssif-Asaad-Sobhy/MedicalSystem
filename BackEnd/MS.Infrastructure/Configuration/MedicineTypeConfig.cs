using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;
using System;

namespace MS.Infrastructure.Configurations
{
    public class MedicineTypeConfiguration : IEntityTypeConfiguration<MedicineType>
    {
        public void Configure(EntityTypeBuilder<MedicineType> builder)
        {
            // Table name
            builder.ToTable("MedicineTypes");

            // Primary key
            builder.HasKey(medicineType => medicineType.ID);

            // MedicineID property
            builder.Property(medicineType => medicineType.MedicineID)
                .IsRequired();
            //.GreaterThan(0) // Adjust the condition as per your requirements
            //.WithMessage("MedicineID must be greater than 0");

            // TypeID property
            builder.Property(medicineType => medicineType.TypeID)
                .IsRequired();
            //.GreaterThan(0) // Adjust the condition as per your requirements
            //.WithMessage("TypeID must be greater than 0");

            // Description property
            builder.Property(medicineType => medicineType.Description)
                .IsRequired()
                .HasMaxLength(400); // Adjust the maximum length as per your requirements
                                    //.WithMessage("Description is required");

            // SideEffects property
            builder.Property(medicineType => medicineType.SideEffects)
                .IsRequired()
                .HasMaxLength(100);// Adjust the maximum length as per your requirements
                                   //.WithMessage("SideEffects is required");

            // Warning property
            builder.Property(medicineType => medicineType.Warning)
                .IsRequired()
                .HasMaxLength(100); // Adjust the maximum length as per your requirements
                                    //.WithMessage("Warning is required");

            // ExpirationDate property
            builder.Property(medicineType => medicineType.ExpirationDate)
                .IsRequired();
                //.GreaterThan(DateTime.Now)
                //.WithMessage("ExpirationDate must be in the future");

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(medicineType => medicineType.SomeProperty);
        }
    }
}
