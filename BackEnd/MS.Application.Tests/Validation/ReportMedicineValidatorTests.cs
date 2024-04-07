using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class ReportMedicineValidatorTests
    {
        private readonly ReportMedicineValidator _validator;

        public ReportMedicineValidatorTests()
        {
            _validator = new ReportMedicineValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmptyOrLessThanOne()
        {
            var model = new ReportMedicine { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reportMedicine => reportMedicine.ID);
        }

        [Fact]
        public void ShouldHaveError_When_ReportID_IsEmptyOrLessThanOne()
        {
            var model = new ReportMedicine { ReportID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reportMedicine => reportMedicine.ReportID);
        }

        [Fact]
        public void ShouldHaveError_When_MedicineTypeID_IsEmptyOrLessThanOne()
        {
            var model = new ReportMedicine { MedicineTypeID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reportMedicine => reportMedicine.MedicineTypeID);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new ReportMedicine
            {
                ID = 1,
                ReportID = 1,
                MedicineTypeID = 1
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(reportMedicine => reportMedicine.ID);
            result.ShouldNotHaveValidationErrorFor(reportMedicine => reportMedicine.ReportID);
            result.ShouldNotHaveValidationErrorFor(reportMedicine => reportMedicine.MedicineTypeID);
        }
    }
}