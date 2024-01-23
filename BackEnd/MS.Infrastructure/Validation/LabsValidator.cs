using FluentValidation;
using MS.Data.Entities;
using MS.Data.Enums;

namespace MS.Infrastructure.Validation
{
    public class LabsValidator : AbstractValidator<Labs>
    {
        public LabsValidator()
        {
            RuleFor(labs => labs.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(labs => labs.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(labs => labs.Type)
                .IsInEnum()
                .WithMessage("Invalid LabType");

            RuleFor(labs => labs.ShiftID)
                .GreaterThan(0)
                .WithMessage("ShiftID must be greater than 0");

            RuleFor(labs => labs.HospitalID)
                .GreaterThan(0)
                .WithMessage("HospitalID must be greater than 0");

            // Add any additional validation rules based on your requirements
        }
    }
}
