using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class ShiftValidator : AbstractValidator<Shift>
    {
        public ShiftValidator()
        {
            RuleFor(shift => shift.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(shift => shift.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(shift => shift.StartTime)
                .NotNull()
                .WithMessage("StartTime is required");

            RuleFor(shift => shift.EndTime)
                .NotNull()
                .WithMessage("EndTime is required")
                .GreaterThanOrEqualTo(shift => shift.StartTime)
                .WithMessage("EndTime must be greater than or equal to StartTime");
        }
    }
}
