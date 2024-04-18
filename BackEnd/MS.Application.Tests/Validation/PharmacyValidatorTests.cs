using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class PharmacyValidatorTests
    {
        private readonly PharmacyValidator _validator;

        public PharmacyValidatorTests()
        {
            _validator = new PharmacyValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new Pharmacy { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacy => pharmacy.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Pharmacy { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacy => pharmacy.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooShort()
        {
            var model = new Pharmacy { Name = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacy => pharmacy.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooLong()
        {
            var model = new Pharmacy { Name = new string('a', 51) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacy => pharmacy.Name);
        }

        [Fact]
        public void ShouldHaveError_When_HospitalID_IsLessThanOrEqualToZero()
        {
            var model = new Pharmacy { HospitalID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pharmacy => pharmacy.HospitalID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Pharmacy
            {
                ID = 1,
                Name = "ValidName",
                HospitalID = 1
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(pharmacy => pharmacy.ID);
            result.ShouldNotHaveValidationErrorFor(pharmacy => pharmacy.Name);
            result.ShouldNotHaveValidationErrorFor(pharmacy => pharmacy.HospitalID);
        }
    }
}