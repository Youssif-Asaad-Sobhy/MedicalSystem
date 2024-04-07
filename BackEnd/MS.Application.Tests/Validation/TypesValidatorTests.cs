using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class TypesValidatorTests
    {
        private readonly TypesValidator _validator;

        public TypesValidatorTests()
        {
            _validator = new TypesValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmptyOrLessThanOne()
        {
            var model = new Types { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(type => type.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Types { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(type => type.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooLong()
        {
            var model = new Types { Name = new string('a', 51) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(type => type.Name);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Types
            {
                ID = 1,
                Name = "Valid Name"
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(type => type.ID);
            result.ShouldNotHaveValidationErrorFor(type => type.Name);
        }
    }
}