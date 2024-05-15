using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class TestsValidatorTests
    {
        private readonly TestsValidator _validator;

        public TestsValidatorTests()
        {
            _validator = new TestsValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOne()
        {
            var model = new Test { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(tests => tests.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Test { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(tests => tests.Name);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Test
            {
                ID = 1,
                Name = "Valid Name"
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(tests => tests.ID);
            result.ShouldNotHaveValidationErrorFor(tests => tests.Name);
        }
    }
}