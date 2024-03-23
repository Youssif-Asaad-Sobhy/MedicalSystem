using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class ClinicValidator : AbstractValidator<Clinic>
    {
        public ClinicValidator()
        {
            RuleFor(c => c.ID).NotEmpty().WithMessage("ID is required");

            RuleFor(c => c.Name).NotEmpty().WithMessage("Name is required");

            RuleFor(c => c.DepartmentID).NotEmpty().WithMessage("DepartmentID is required");
        }
    }
}
