using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class PharmacyValidator : AbstractValidator<Pharmacy>
    {
        public PharmacyValidator()
        {
            RuleFor(pharmacy => pharmacy.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(pharmacy => pharmacy.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .Length(3, 50)
                .WithMessage("Name must be between 3 and 50 characters");

            RuleFor(pharmacy => pharmacy.HospitalID)
                .GreaterThan(0)
                .WithMessage("HospitalID must be greater than 0");
        }
    }
}
