using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class HospitalValidator : AbstractValidator<Hospital>
    {
        public HospitalValidator()
        {
            RuleFor(hospital => hospital.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(hospital => hospital.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .Length(3, 50)
                .WithMessage("Name must be between 3 and 50 characters");

            RuleFor(hospital => hospital.Phone)
                .NotEmpty()
                .WithMessage("Phone is required")
                .Matches("^\\d{10,15}$")
                .WithMessage("Phone must be a valid numeric value with 10 to 15 digits")
                .Length(11)
                .WithMessage("phone number must be 11 digits");

            RuleFor(hospital => hospital.Government)
                .NotEmpty()
                .WithMessage("Government is required");

            RuleFor(hospital => hospital.City)
                .NotEmpty()
                .WithMessage("City is required");

            RuleFor(hospital => hospital.Country)
                .NotEmpty()
                .WithMessage("Country is required");

            RuleFor(hospital => hospital.Type)
                .IsInEnum()
                .WithMessage("Invalid HospitalType");
        }
    }
}
