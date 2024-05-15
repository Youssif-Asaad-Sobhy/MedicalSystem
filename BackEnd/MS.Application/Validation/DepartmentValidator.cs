using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            // Validation rules from the first DepartmentValidator
            RuleFor(department => department.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(department => department.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .Matches("^[a-zA-Z]+$")
                .WithMessage("Name must contain only alphabetical characters");

            RuleFor(department => department.HospitalID)
                .GreaterThan(0)
                .WithMessage("HospitalID must be greater than 0");
        }
    }
}
