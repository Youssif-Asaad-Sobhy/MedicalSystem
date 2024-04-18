using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class TestLabValidatorTests
    {
        private readonly TestLabValidator _validator;

        public TestLabValidatorTests()
        {
            _validator = new TestLabValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmptyOrLessThanOne()
        {
            var model = new TestLab { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(testLab => testLab.ID);
        }

        [Fact]
        public void ShouldHaveError_When_TestLabID_IsEmptyOrLessThanOne()
        {
            var model = new TestLab { TestLabID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(testLab => testLab.TestLabID);
        }

        [Fact]
        public void ShouldHaveError_When_LabID_IsEmptyOrLessThanOne()
        {
            var model = new TestLab { LabID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(testLab => testLab.LabID);
        }

        [Fact]
        public void ShouldHaveError_When_Price_IsNegative()
        {
            var model = new TestLab { Price = -1 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(testLab => testLab.Price);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsEmpty()
        {
            var model = new TestLab { Description = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(testLab => testLab.Description);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsTooLong()
        {
            var model = new TestLab { Description = new string('a', 201) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(testLab => testLab.Description);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new TestLab
            {
                ID = 1,
                TestLabID = 1,
                LabID = 1,
                Price = 0,
                Description = "Valid Description"
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(testLab => testLab.ID);
            result.ShouldNotHaveValidationErrorFor(testLab => testLab.TestLabID);
            result.ShouldNotHaveValidationErrorFor(testLab => testLab.LabID);
            result.ShouldNotHaveValidationErrorFor(testLab => testLab.Price);
            result.ShouldNotHaveValidationErrorFor(testLab => testLab.Description);
        }
    }
}