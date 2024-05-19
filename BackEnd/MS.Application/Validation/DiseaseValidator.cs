using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class DiseaseValidator : AbstractValidator<Disease>
    {
        public DiseaseValidator()
        {
            RuleFor(d => d.ID).NotEmpty().WithMessage("ID is required");

            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("Name is required")
                .Length(1, 100).WithMessage("Name must be between 1 and 100 characters");

            RuleFor(d => d.Description)
                .NotEmpty().WithMessage("Description is required");

            RuleFor(d => d.Symptoms)
                .NotEmpty().WithMessage("Symptoms are required");

            RuleFor(d => d.Causes)
                .NotEmpty().WithMessage("Causes are required");

            RuleFor(d => d.UserDiseases)
                .NotEmpty().WithMessage("UserDiseases are required");
        }
    }
}