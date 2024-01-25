using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class ClinicPriceValidator : AbstractValidator<ClinicPrice>
    {
        public ClinicPriceValidator()
        {
            RuleFor(cp => cp.ID).NotEmpty().WithMessage("ID is required");

            RuleFor(cp => cp.ClinicID).NotEmpty().WithMessage("ClinicID is required");

            RuleFor(cp => cp.Name).NotNull().WithMessage("Name is Required");

            RuleFor(cp => cp.Price).NotEmpty().WithMessage("Price is required")
                                   .GreaterThanOrEqualTo(1).WithMessage("Price must be greater than or equal to 1");
        }
    }
}
