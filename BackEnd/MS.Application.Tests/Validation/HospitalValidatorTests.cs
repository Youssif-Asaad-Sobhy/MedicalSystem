using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using MS.Data.Enums;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class HospitalValidatorTests
    {
        private readonly HospitalValidator _validator;

        public HospitalValidatorTests()
        {
            _validator = new HospitalValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new Hospital { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsEmpty()
        {
            var model = new Hospital { Name = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooShort()
        {
            var model = new Hospital { Name = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Name_IsTooLong()
        {
            var model = new Hospital { Name = new string('a', 51) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Name);
        }

        [Fact]
        public void ShouldHaveError_When_Phone_IsEmpty()
        {
            var model = new Hospital { Phone = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Phone);
        }

        [Fact]
        public void ShouldHaveError_When_Phone_IsNotValid()
        {
            var model = new Hospital { Phone = "123456789" }; // less than 10 digits
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Phone);
        }

        [Fact]
        public void ShouldHaveError_When_Government_IsEmpty()
        {
            var model = new Hospital { Government = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Government);
        }

        [Fact]
        public void ShouldHaveError_When_City_IsEmpty()
        {
            var model = new Hospital { City = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.City);
        }

        [Fact]
        public void ShouldHaveError_When_Country_IsEmpty()
        {
            var model = new Hospital { Country = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Country);
        }

        [Fact]
        public void ShouldHaveError_When_Type_IsInvalid()
        {
            var model = new Hospital { Type = (HospitalType)100 }; // Invalid enum value
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(hospital => hospital.Type);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Hospital
            {
                ID = 1,
                Name = "ValidName",
                Phone = "12345678901",
                Government = "ValidGovernment",
                City = "ValidCity",
                Country = "ValidCountry",
                Type = HospitalType.Public
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(hospital => hospital.ID);
            result.ShouldNotHaveValidationErrorFor(hospital => hospital.Name);
            result.ShouldNotHaveValidationErrorFor(hospital => hospital.Phone);
            result.ShouldNotHaveValidationErrorFor(hospital => hospital.Government);
            result.ShouldNotHaveValidationErrorFor(hospital => hospital.City);
            result.ShouldNotHaveValidationErrorFor(hospital => hospital.Country);
            result.ShouldNotHaveValidationErrorFor(hospital => hospital.Type);
        }
    }
}