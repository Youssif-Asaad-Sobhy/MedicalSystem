using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class ShiftValidatorTests
    {
        private readonly ShiftValidator _validator;

        public ShiftValidatorTests()
        {
            _validator = new ShiftValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOne()
        {
            var model = new Shift { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(shift => shift.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Shift { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(shift => shift.Name);
        }

        [Fact]
        public void ShouldHaveError_When_StartTime_IsNull()
        {
            var model = new Shift { StartTime = null };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(shift => shift.StartTime);
        }

        [Fact]
        public void ShouldHaveError_When_EndTime_IsNull()
        {
            var model = new Shift { EndTime = null };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(shift => shift.EndTime);
        }

        [Fact]
        public void ShouldHaveError_When_EndTime_IsLessThan_StartTime()
        {
            var model = new Shift { StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(-1) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(shift => shift.EndTime);
        }

        [Fact]
        public void ShouldHaveError_When_EntityID_IsEmptyOrLessThanOne()
        {
            var model = new Shift { EntityID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(shift => shift.EntityID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Shift
            {
                ID = 1,
                Name = "Valid Name",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(1),
                EntityID = 1
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(shift => shift.ID);
            result.ShouldNotHaveValidationErrorFor(shift => shift.Name);
            result.ShouldNotHaveValidationErrorFor(shift => shift.StartTime);
            result.ShouldNotHaveValidationErrorFor(shift => shift.EndTime);
            result.ShouldNotHaveValidationErrorFor(shift => shift.EntityID);
        }
    }
}