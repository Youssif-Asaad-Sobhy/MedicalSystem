using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace MS.Infrastructure.Configuration
{
    public class HospitalEntityTypeConfiguration: IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasKey(h => h.ID);
        }
    }
}
