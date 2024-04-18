using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class DocumentValidatorTests
    {
        private readonly DocumentValidator _validator;

        public DocumentValidatorTests()
        {
            _validator = new DocumentValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new Document { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(document => document.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Content_IsEmpty()
        {
            var model = new Document { Content = new byte[0] };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(document => document.Content);
        }

        [Fact]
        public void ShouldHaveError_When_ReportID_IsLessThanOrEqualToZero()
        {
            var model = new Document { ReportID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(document => document.ReportID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Document { ID = 1, Content = new byte[] { 1, 2, 3 }, ReportID = 1 };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(document => document.ID);
            result.ShouldNotHaveValidationErrorFor(document => document.Content);
            result.ShouldNotHaveValidationErrorFor(document => document.ReportID);
        }
    }
}