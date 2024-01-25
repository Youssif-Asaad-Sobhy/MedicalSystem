using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace MS.Infrastructure.Configuration
{
    public class HospitalConfig: IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasKey(h => h.ID);

            builder.HasMany(h=>h.Pharmacies)
                .WithOne(p=>p.Hospital)
                .HasForeignKey(p=>p.HospitalID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
