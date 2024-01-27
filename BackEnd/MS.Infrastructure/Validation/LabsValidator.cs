using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class LabValidator : AbstractValidator<Lab>
    {
        public LabValidator()
        {
            RuleFor(lab => lab.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(lab => lab.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .Length(3, 50)
                .WithMessage("Name must be between 3 and 50 characters");

            RuleFor(lab => lab.Type)
                .IsInEnum()
                .WithMessage("Invalid LabType");

            RuleFor(lab => lab.HospitalID)
                .GreaterThan(0)
                .WithMessage("HospitalID must be greater than 0");
        

        }
    }
}
