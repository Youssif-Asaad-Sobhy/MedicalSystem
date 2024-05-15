using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class ReportValidatorTests
    {
        private readonly ReportValidator _validator;

        public ReportValidatorTests()
        {
            _validator = new ReportValidator();
        }

        [Fact]
        public void ShouldHaveError_When_Time_IsEmpty()
        {
            var model = new Report { Time = default(DateTime) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(r => r.Time);
        }

        [Fact]
        public void ShouldHaveError_When_Time_IsInFuture()
        {
            var model = new Report { Time = DateTime.UtcNow.AddDays(1) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(r => r.Time);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsEmpty()
        {
            var model = new Report { Description = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(r => r.Description);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsTooLong()
        {
            var model = new Report { Description = new string('a', 256) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(r => r.Description);
        }

        [Fact]
        public void ShouldHaveError_When_UserID_IsEmpty()
        {
            var model = new Report { UserID = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(r => r.UserID);
        }

        [Fact]
        public void ShouldHaveError_When_DoctorID_IsEmpty()
        {
            var model = new Report { DoctorID = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(r => r.DoctorID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Report
            {
                Time = DateTime.UtcNow,
                Description = "Valid Description",
                UserID = "ValidUserID",
                DoctorID = "ValidDoctorID"
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(r => r.Time);
            result.ShouldNotHaveValidationErrorFor(r => r.Description);
            result.ShouldNotHaveValidationErrorFor(r => r.UserID);
            result.ShouldNotHaveValidationErrorFor(r => r.DoctorID);
        }
    }
}