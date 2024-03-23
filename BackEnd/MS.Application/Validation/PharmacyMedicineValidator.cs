using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class PharmacyMedicineValidator : AbstractValidator<PharmacyMedicine>
    {
        public PharmacyMedicineValidator()
        {
            RuleFor(pharmacyMedicine => pharmacyMedicine.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(pharmacyMedicine => pharmacyMedicine.PharmacyID)
                .GreaterThan(0)
                .WithMessage("PharmacyID must be greater than 0");

            RuleFor(pharmacyMedicine => pharmacyMedicine.MedicineTypeID)
                .GreaterThan(0)
                .WithMessage("MedicineTypeID must be greater than 0");

            RuleFor(pharmacyMedicine => pharmacyMedicine.Amount)
                .GreaterThan(0)
                .WithMessage("Amount must be greater than 0");

            RuleFor(pharmacyMedicine => pharmacyMedicine.Price)
                .GreaterThan(0)
                .WithMessage("Price must be greater than 0");
        }
    }
}
