using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;

namespace MS.Infrastructure.Configurations
{
    public class EntityAuthConfiguration : IEntityTypeConfiguration<EntityAuth>
    {
        public void Configure(EntityTypeBuilder<EntityAuth> builder)
        {
            // Table name
            builder.ToTable("EntityAuths");

            // Primary key
            builder.HasKey(ea => ea.ID);

            // UserID property
            builder.Property(ea => ea.UserID)
                .IsRequired();
            // PlaceType property
            builder.Property(ea => ea.PlaceType)
                .IsRequired()
                .HasConversion<string>();

            // EntityID property
            builder.Property(ea => ea.EntityID)
                .IsRequired();
            // Additional configuration if needed
        }
    }
}
