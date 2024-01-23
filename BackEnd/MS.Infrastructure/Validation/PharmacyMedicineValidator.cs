using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class PharmacyMedicineValidator : AbstractValidator<PharmacyMedicine>
    {
        public PharmacyMedicineValidator()
        {
            RuleFor(pharmacyMedicine => pharmacyMedicine.ID)
                .NotEmpty().WithMessage("ID is required")
                .GreaterThan(0).WithMessage("ID must be greater than 0");

            RuleFor(pharmacyMedicine => pharmacyMedicine.PharmacyID)
                .NotEmpty().WithMessage("PharmacyID is required")
                .GreaterThan(0).WithMessage("PharmacyID must be greater than 0");

            RuleFor(pharmacyMedicine => pharmacyMedicine.MedicineID)
                .NotEmpty().WithMessage("MedicineID is required")
                .GreaterThan(0).WithMessage("MedicineID must be greater than 0");

            RuleFor(pharmacyMedicine => pharmacyMedicine.Amount)
                .NotEmpty().WithMessage("Amount is required")
                .GreaterThan(0).WithMessage("Amount must be greater than 0");
        }
    }
}
