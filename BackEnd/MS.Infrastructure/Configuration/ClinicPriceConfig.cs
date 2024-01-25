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
    public class ClinicPriceConfig : IEntityTypeConfiguration<ClinicPrice>
    {
        public void Configure(EntityTypeBuilder<ClinicPrice> builder) 
        {
            builder.HasKey(c => c.ID);

        }
    }
}
