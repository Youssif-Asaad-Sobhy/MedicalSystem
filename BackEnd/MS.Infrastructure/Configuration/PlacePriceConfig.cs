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
    public class PlacePriceConfig : IEntityTypeConfiguration<PlacePrice>
    {
        public void Configure(EntityTypeBuilder<PlacePrice> builder) 
        {
            builder.HasKey(c => c.ID);
        }
    }
}
