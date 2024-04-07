using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class EquipmentValidatorTests
    {
        private readonly EquipmentValidator _validator;

        public EquipmentValidatorTests()
        {
            _validator = new EquipmentValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new Equipment { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Equipment { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooShort()
        {
            var model = new Equipment { Name = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooLong()
        {
            var model = new Equipment { Name = new string('a', 51) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_ContainsNonAlphanumericCharacters()
        {
            var model = new Equipment { Name = "abc!" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsEmpty()
        {
            var model = new Equipment { Description = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.Description);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsTooShort()
        {
            var model = new Equipment { Description = "short" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.Description);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsTooLong()
        {
            var model = new Equipment { Description = new string('a', 201) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(equipment => equipment.Description);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Equipment { ID = 1, Name = "ValidName", Description = "Valid Description" };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(equipment => equipment.ID);
            result.ShouldNotHaveValidationErrorFor(equipment => equipment.Name);
            result.ShouldNotHaveValidationErrorFor(equipment => equipment.Description);
        }
    }
}