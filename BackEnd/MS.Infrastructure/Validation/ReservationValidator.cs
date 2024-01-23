using FluentValidation;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Validation
{
    internal class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator() 
        {
            RuleFor(x=>x.ID)
                .NotNull()
                .NotEmpty
        }
    }
}
