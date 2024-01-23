using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class ClinicValidator : AbstractValidator<Clinic>
    {
        public ClinicValidator()
        {
            RuleFor(clinic => clinic.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(clinic => clinic.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(clinic => clinic.ShiftID)
                .GreaterThan(0)
                .WithMessage("ShiftID must be greater than 0");

            RuleFor(clinic => clinic.DepartmentID)
                .GreaterThan(0)
                .WithMessage("DepartmentID must be greater than 0");
        }
    }
}
