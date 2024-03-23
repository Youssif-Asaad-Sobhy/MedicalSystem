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
    internal class PlaceShiftConfig : IEntityTypeConfiguration<PlaceShift>
    {
        public void Configure(EntityTypeBuilder<PlaceShift> builder)
        {
            builder.HasKey(ps => ps.ID);
        }
    }
}
