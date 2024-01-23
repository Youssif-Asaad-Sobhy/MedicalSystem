using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class MedicineTypeValidator : AbstractValidator<MedicineType>
    {
        public MedicineTypeValidator()
        {
            RuleFor(medicineType => medicineType.ID)
                .NotEmpty().WithMessage("ID is required")
                .GreaterThan(0).WithMessage("ID must be greater than 0");

            RuleFor(medicineType => medicineType.MedicineID)
                .NotEmpty().WithMessage("MedicineID is required")
                .GreaterThan(0).WithMessage("MedicineID must be greater than 0");

            RuleFor(medicineType => medicineType.TypeID)
                .NotEmpty().WithMessage("TypeID is required")
                .GreaterThan(0).WithMessage("TypeID must be greater than 0");

            RuleFor(medicineType => medicineType.Price)
                .GreaterThanOrEqualTo(0).WithMessage("Price must be non-negative");

            RuleFor(medicineType => medicineType.Description)
                .NotEmpty().WithMessage("Description is required")
                .MaximumLength(200).WithMessage("Description cannot exceed 200 characters");

            RuleFor(medicineType => medicineType.SideEffects)
                .MaximumLength(200).WithMessage("SideEffects cannot exceed 200 characters");

            RuleFor(medicineType => medicineType.Warning)
                .MaximumLength(200).WithMessage("Warning cannot exceed 200 characters");

            RuleFor(medicineType => medicineType.ExpirationDate)
                .Must(BeInFuture).WithMessage("ExpirationDate must be in the future");
        }

        // Custom validation method to check if the expiration duration is in the future
        private bool BeInFuture(DateTime ExpirationDate)
        {
            return ExpirationDate > DateTime.Now;
        }
    }
}
