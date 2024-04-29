using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Configuration
{
    public class UserDiseaseConfig: IEntityTypeConfiguration<ApplicationUserDisease>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserDisease> builder)
        {
            builder.HasKey(ud => ud.ID);

            builder.HasOne(ud => ud.ApplicationUser)
                .WithMany(u => u.UserDiseases)
                .HasForeignKey(ud => ud.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ud => ud.Disease)
                .WithMany(d => d.UserDiseases)
                .HasForeignKey(ud => ud.DiseaseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(ud => ud.Diagnosis).IsRequired().HasMaxLength(100);
            builder.Property(ud => ud.DiagnosisDate).IsRequired();
 
        }   
    }
}
