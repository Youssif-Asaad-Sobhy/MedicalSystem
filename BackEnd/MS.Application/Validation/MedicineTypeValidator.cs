using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class MedicineTypeValidator : AbstractValidator<MedicineType>
    {
        public MedicineTypeValidator()
        {
            RuleFor(medicineType => medicineType.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(medicineType => medicineType.MedicineID)
                .GreaterThan(0)
                .WithMessage("MedicineID must be greater than 0");

            RuleFor(medicineType => medicineType.TypeID)
                .GreaterThan(0)
                .WithMessage("TypeID must be greater than 0");

            RuleFor(medicineType => medicineType.Description)
                .NotEmpty()
                .WithMessage("Description is required")
                .Length(3, 400)
                .WithMessage("Description must be between 3 and 100 characters");

            RuleFor(medicineType => medicineType.SideEffects)
                .NotEmpty()
                .WithMessage("SideEffects is required")
                .Length(3, 100)
                .WithMessage("SideEffects must be between 3 and 100 characters");

            RuleFor(medicineType => medicineType.Warning)
                .NotEmpty()
                .WithMessage("Warning is required")
                .Length(3, 100)
                .WithMessage("Warning must be between 3 and 100 characters");

            RuleFor(medicineType => medicineType.ExpirationDate)
                .NotEmpty()
                .WithMessage("ExpirationDate is required")
                .GreaterThan(DateTime.Now)
                .WithMessage("ExpirationDate must be in the future");
        }
    }
}
