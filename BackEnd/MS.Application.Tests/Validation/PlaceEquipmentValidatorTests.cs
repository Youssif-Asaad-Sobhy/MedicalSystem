using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using MS.Data.Enums;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class PlaceEquipmentValidatorTests
    {
        private readonly PlaceEquipmentValidator _validator;

        public PlaceEquipmentValidatorTests()
        {
            _validator = new PlaceEquipmentValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmpty()
        {
            var model = new PlaceEquipment { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pe => pe.ID);
        }

        [Fact]
        public void ShouldHaveError_When_EquipmentID_IsEmpty()
        {
            var model = new PlaceEquipment { EquipmentID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pe => pe.EquipmentID);
        }

        [Fact]
        public void ShouldHaveError_When_EntityID_IsEmpty()
        {
            var model = new PlaceEquipment { EntityID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pe => pe.EntityID);
        }

        [Fact]
        public void ShouldHaveError_When_PlaceType_IsInvalid()
        {
            var model = new PlaceEquipment { PlaceType = (PlaceType)999 }; // Invalid enum value
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(pe => pe.PlaceType);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new PlaceEquipment
            {
                ID = 1,
                EquipmentID = 1,
                EntityID = 1,
                PlaceType = PlaceType.Clinic // Assuming Hospital is a valid enum value
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(pe => pe.ID);
            result.ShouldNotHaveValidationErrorFor(pe => pe.EquipmentID);
            result.ShouldNotHaveValidationErrorFor(pe => pe.EntityID);
            result.ShouldNotHaveValidationErrorFor(pe => pe.PlaceType);
        }
    }
}