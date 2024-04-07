using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using MS.Data.Enums;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class LabValidatorTests
    {
        private readonly LabValidator _validator;

        public LabValidatorTests()
        {
            _validator = new LabValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new Lab { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(lab => lab.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Lab { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(lab => lab.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooShort()
        {
            var model = new Lab { Name = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(lab => lab.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooLong()
        {
            var model = new Lab { Name = new string('a', 51) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(lab => lab.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Type_IsInvalid()
        {
            var model = new Lab { Type = (LabType)100 }; // Invalid enum value
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(lab => lab.Type);
        }

        [Fact]
        public void ShouldHaveError_When_HospitalID_IsLessThanOrEqualToZero()
        {
            var model = new Lab { HospitalID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(lab => lab.HospitalID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Lab
            {
                ID = 1,
                Name = "ValidName",
                Type = LabType.Lab,
                HospitalID = 1
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(lab => lab.ID);
            result.ShouldNotHaveValidationErrorFor(lab => lab.Name);
            result.ShouldNotHaveValidationErrorFor(lab => lab.Type);
            result.ShouldNotHaveValidationErrorFor(lab => lab.HospitalID);
        }
    }
}