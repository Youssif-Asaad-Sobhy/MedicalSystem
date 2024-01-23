using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class PharmacyValidator : AbstractValidator<Pharmacy>
    {
        public PharmacyValidator()
        {
            RuleFor(pharmacy => pharmacy.ID)
                .NotEmpty().WithMessage("ID is required")
                .GreaterThan(0).WithMessage("ID must be greater than 0");

            RuleFor(pharmacy => pharmacy.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters");

            RuleFor(pharmacy => pharmacy.HospitalID)
                .NotEmpty().WithMessage("HospitalID is required")
                .GreaterThan(0).WithMessage("HospitalID must be greater than 0");

            RuleFor(pharmacy => pharmacy.ShiftID)
                .NotEmpty().WithMessage("ShiftID is required")
                .GreaterThan(0).WithMessage("ShiftID must be greater than 0");
        }
    }
}
