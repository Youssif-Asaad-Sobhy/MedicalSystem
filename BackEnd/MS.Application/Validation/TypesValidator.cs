using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class TypesValidator : AbstractValidator<Types>
    {
        public TypesValidator()
        {
            RuleFor(type => type.ID)
                .NotEmpty().WithMessage("ID is required")
                .GreaterThan(0).WithMessage("ID must be greater than 0");

            RuleFor(type => type.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters");
        }
    }
}
