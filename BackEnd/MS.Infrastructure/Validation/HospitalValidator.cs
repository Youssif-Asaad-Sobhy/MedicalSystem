using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class HospitalValidator : AbstractValidator<Hospital>
    {
        public HospitalValidator()
        {
            RuleFor(x => x.ID)
                .NotNull()
                .WithMessage("ID is required");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("Name is required");

            RuleFor(x => x.Phone)
                .NotNull()
                .WithMessage("Phone is required")
                .Length(11)
                .WithMessage("Phone must be 11 characters long");

            RuleFor(x => x.Government)
                .NotNull()
                .WithMessage("Government is required");

            RuleFor(x => x.City)
                .NotNull()
                .WithMessage("City is required");

            RuleFor(x => x.Country)
                .NotEmpty()
                .WithMessage("Country is required");

            RuleFor(x => x.Type)
                .NotNull()
                .WithMessage("Type is required");
        }
    }
}
