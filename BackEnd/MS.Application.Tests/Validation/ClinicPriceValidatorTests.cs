using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class ClinicPriceValidatorTests
    {
        private readonly ClinicPriceValidator _validator;

        public ClinicPriceValidatorTests()
        {
            _validator = new ClinicPriceValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmpty()
        {
            var model = new PlacePrice { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(cp => cp.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new PlacePrice { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(cp => cp.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Price_IsLessThanOne()
        {
            var model = new PlacePrice { Price = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(cp => cp.Price);
        }

        [Fact]
        public void ShouldHaveError_When_PlaceID_IsEmpty()
        {
            var model = new PlacePrice { PlaceID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(cp => cp.PlaceID);
        }
        [Fact]
        public void ShouldNotHaveError_When_ID_IsValid()
        {
            var model = new PlacePrice { ID = 1 };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(cp => cp.ID);
        }

        [Fact]
        public void ShouldNotHaveError_When_Name_IsValid()
        {
            var model = new PlacePrice { Name = "Valid Name" };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(cp => cp.Name);
        }

        [Fact]
        public void ShouldNotHaveError_When_Price_IsValid()
        {
            var model = new PlacePrice { Price = 1 };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(cp => cp.Price);
        }

        [Fact]
        public void ShouldNotHaveError_When_PlaceID_IsValid()
        {
            var model = new PlacePrice { PlaceID = 1 };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(cp => cp.PlaceID);
        }
    }
}