using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class EquipmentValidator : AbstractValidator<Equipment>
    {
        public EquipmentValidator()
        {
            RuleFor(equipment => equipment.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(equipment => equipment.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .Length(3, 50)
                .WithMessage("Name must be between 3 and 50 characters")
                .Matches("^[a-zA-Z0-9_]+$")
                .WithMessage("Name must contain only alphanumeric characters and underscores");

            RuleFor(equipment => equipment.Description)
                .NotEmpty()
                .WithMessage("Description is required")
                .Length(10, 200)
                .WithMessage("Description must be between 10 and 200 characters");
        }
    }
}
