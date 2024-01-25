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
    internal class EntityAuthConfig : IEntityTypeConfiguration<EntityAuth>
    {
        public void Configure(EntityTypeBuilder<EntityAuth> builder)
        {
            builder.HasKey(e => e.ID);
        }
    }
}
