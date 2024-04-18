using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class MedicineValidatorTests
    {
        private readonly MedicineValidator _validator;

        public MedicineValidatorTests()
        {
            _validator = new MedicineValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new Medicine { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicine => medicine.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Medicine { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicine => medicine.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooShort()
        {
            var model = new Medicine { Name = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicine => medicine.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooLong()
        {
            var model = new Medicine { Name = new string('a', 51) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicine => medicine.Name);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Medicine { ID = 1, Name = "ValidName" };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(medicine => medicine.ID);
            result.ShouldNotHaveValidationErrorFor(medicine => medicine.Name);
        }
    }
}