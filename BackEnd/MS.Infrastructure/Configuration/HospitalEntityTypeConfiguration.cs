using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FluentValidation;
using MS.Infrastructure.Validation;
namespace MS.Infrastructure.Configuration
{
    public class HospitalEntityTypeConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            
        }
    }
}
