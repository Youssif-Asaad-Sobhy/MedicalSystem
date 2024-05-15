using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class ClinicPriceValidator : AbstractValidator<PlacePrice>
    {
        public ClinicPriceValidator()
        {
            RuleFor(cp => cp.ID).NotEmpty().WithMessage("ID is required");

            RuleFor(cp => cp.Name).NotEmpty().WithMessage("Name is required");

            RuleFor(cp => cp.Price).NotEmpty().WithMessage("Price is required")
                                   .GreaterThanOrEqualTo(1).WithMessage("Price must be greater than or equal to 1");

            RuleFor(cp => cp.PlaceID).NotEmpty().WithMessage("PlaceID is required");
        }
    }
}
