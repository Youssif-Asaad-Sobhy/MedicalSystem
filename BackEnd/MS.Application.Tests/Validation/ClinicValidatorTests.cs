using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class ClinicValidatorTests
    {
        private readonly ClinicValidator _validator;

        public ClinicValidatorTests()
        {
            _validator = new ClinicValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmpty()
        {
            var model = new Clinic { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(c => c.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Clinic { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(c => c.Name);
        }

        [Fact]
        public void ShouldHaveError_When_DepartmentID_IsEmpty()
        {
            var model = new Clinic { DepartmentID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(c => c.DepartmentID);
        }

        [Fact]
        public void ShouldNotHaveError_When_ID_IsValid()
        {
            var model = new Clinic { ID = 1 };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(c => c.ID);
        }

        [Fact]
        public void ShouldNotHaveError_When_Name_IsValid()
        {
            var model = new Clinic { Name = "Valid Name" };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(c => c.Name);
        }

        [Fact]
        public void ShouldNotHaveError_When_DepartmentID_IsValid()
        {
            var model = new Clinic { DepartmentID = 1 };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(c => c.DepartmentID);
        }
    }
}