using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            // Table name
            builder.ToTable("Documents");

            // Primary key
            builder.HasKey(document => document.ID);

            // Content property
            builder.Property(document => document.Content)
                .IsRequired()
                .HasMaxLength(255); // Adjust the maximum length as per your requirements

            // ReportID property
            builder.Property(document => document.ReportID)
                .IsRequired();

            // Additional configuration if needed
        }
    }
}
