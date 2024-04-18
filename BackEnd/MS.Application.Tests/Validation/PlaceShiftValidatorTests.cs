using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using MS.Data.Enums;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class PlaceShiftValidatorTests
    {
        private readonly PlaceShiftValidator _validator;

        public PlaceShiftValidatorTests()
        {
            _validator = new PlaceShiftValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmptyOrLessThanOne()
        {
            var model = new PlaceShift { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(placeShift => placeShift.ID);
        }

        [Fact]
        public void ShouldHaveError_When_EntityID_IsEmptyOrLessThanOne()
        {
            var model = new PlaceShift { EntityID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(placeShift => placeShift.EntityID);
        }

        [Fact]
        public void ShouldHaveError_When_PlaceType_IsInvalid()
        {
            var model = new PlaceShift { PlaceType = (PlaceType)999 }; // Invalid enum value
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(placeShift => placeShift.PlaceType);
        }

        [Fact]
        public void ShouldHaveError_When_ShiftID_IsEmpty()
        {
            var model = new PlaceShift { ShiftID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(placeShift => placeShift.ShiftID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new PlaceShift
            {
                ID = 1,
                EntityID = 1,
                PlaceType = PlaceType.Pharmacy, // Assuming Hospital is a valid enum value
                ShiftID = 1
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(placeShift => placeShift.ID);
            result.ShouldNotHaveValidationErrorFor(placeShift => placeShift.EntityID);
            result.ShouldNotHaveValidationErrorFor(placeShift => placeShift.PlaceType);
            result.ShouldNotHaveValidationErrorFor(placeShift => placeShift.ShiftID);
        }
    }
}