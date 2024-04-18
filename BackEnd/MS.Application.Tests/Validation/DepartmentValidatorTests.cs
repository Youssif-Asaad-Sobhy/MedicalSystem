using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class DepartmentValidatorTests
    {
        private readonly DepartmentValidator _validator;

        public DepartmentValidatorTests()
        {
            _validator = new DepartmentValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new Department { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(department => department.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Department { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(department => department.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_ContainsNonAlphabeticalCharacters()
        {
            var model = new Department { Name = "123" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(department => department.Name);
        }

        [Fact]
        public void ShouldHaveError_When_HospitalID_IsLessThanOrEqualToZero()
        {
            var model = new Department { HospitalID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(department => department.HospitalID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Department { ID = 1, Name = "ValidName", HospitalID = 1 };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(department => department.ID);
            result.ShouldNotHaveValidationErrorFor(department => department.Name);
            result.ShouldNotHaveValidationErrorFor(department => department.HospitalID);
        }
    }
}