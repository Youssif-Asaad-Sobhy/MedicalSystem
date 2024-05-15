using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class MedicineValidator : AbstractValidator<Medicine>
    {
        public MedicineValidator()
        {
            RuleFor(medicine => medicine.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(medicine => medicine.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .Length(3, 50)
                .WithMessage("Name must be between 3 and 50 characters");
        }
    }
}
