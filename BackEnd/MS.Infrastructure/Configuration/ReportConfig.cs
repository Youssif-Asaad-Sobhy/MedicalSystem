using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            // Table name
            builder.ToTable("Reports");

            // Primary key
            builder.HasKey(r => r.ID);

            // Time property
            builder.Property(r => r.Time)
                .IsRequired();

            // Description property
            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(255);

            // UserID property
            builder.Property(r => r.UserID)
                .IsRequired();

            // DoctorID property
            builder.Property(r => r.DoctorID)
                .IsRequired();

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(r => r.SomeProperty);
        }
    }
}
