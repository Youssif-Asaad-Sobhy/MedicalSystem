using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class PharmacyMedicineValidatorTests
    {
        private readonly PharmacyMedicineValidator _validator;

        public PharmacyMedicineValidatorTests()
        {
            _validator = new PharmacyMedicineValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new PharmacyMedicine { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.ID);
        }

        [Fact]
        public void ShouldHaveError_When_PharmacyID_IsLessThanOrEqualToZero()
        {
            var model = new PharmacyMedicine { PharmacyID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.PharmacyID);
        }

        [Fact]
        public void ShouldHaveError_When_MedicineTypeID_IsLessThanOrEqualToZero()
        {
            var model = new PharmacyMedicine { MedicineTypeID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.MedicineTypeID);
        }

        [Fact]
        public void ShouldHaveError_When_Amount_IsLessThanOrEqualToZero()
        {
            var model = new PharmacyMedicine { Amount = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.Amount);
        }

        [Fact]
        public void ShouldHaveError_When_Price_IsLessThanOrEqualToZero()
        {
            var model = new PharmacyMedicine { Price = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.Price);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new PharmacyMedicine
            {
                ID = 1,
                PharmacyID = 1,
                MedicineTypeID = 1,
                Amount = 1,
                Price = 1
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.ID);
            result.ShouldNotHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.PharmacyID);
            result.ShouldNotHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.MedicineTypeID);
            result.ShouldNotHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.Amount);
            result.ShouldNotHaveValidationErrorFor(pharmacyMedicine => pharmacyMedicine.Price);
        }
    }
}