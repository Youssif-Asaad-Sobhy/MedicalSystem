using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Table name
            builder.ToTable("Departments");

            // Primary key
            builder.HasKey(department => department.ID);

            // Name property
            builder.Property(department => department.Name)
                .IsRequired()
                .HasMaxLength(255);

            // HospitalID property
            builder.Property(department => department.HospitalID)
                .IsRequired();

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(department => department.SomeProperty);
        }
    }
}
