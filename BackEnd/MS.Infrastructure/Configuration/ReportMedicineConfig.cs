using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class ReportMedicineConfiguration : IEntityTypeConfiguration<ReportMedicine>
    {
        public void Configure(EntityTypeBuilder<ReportMedicine> builder)
        {
            // Table name
            builder.ToTable("ReportMedicines");

            // Primary key
            builder.HasKey(reportMedicine => reportMedicine.ID);

            // ID property
            builder.Property(reportMedicine => reportMedicine.ID)
                .IsRequired()
;//                .GreaterThan(0);

            // ReportID property
            builder.Property(reportMedicine => reportMedicine.ReportID)
                .IsRequired()
   ;//             .GreaterThan(0);

            // MedicineTypeID property
            builder.Property(reportMedicine => reportMedicine.MedicineTypeID)
                .IsRequired()
      ;//          .GreaterThan(0);

            // Additional configuration if needed

            // Example: Ignore any other properties not mapped here
            // builder.Ignore(reportMedicine => reportMedicine.SomeProperty);
        }
    }
}
