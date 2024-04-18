using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using System;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class MedicineTypeValidatorTests
    {
        private readonly MedicineTypeValidator _validator;

        public MedicineTypeValidatorTests()
        {
            _validator = new MedicineTypeValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsLessThanOrEqualToZero()
        {
            var model = new MedicineType { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.ID);
        }

        [Fact]
        public void ShouldHaveError_When_MedicineID_IsLessThanOrEqualToZero()
        {
            var model = new MedicineType { MedicineID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.MedicineID);
        }

        [Fact]
        public void ShouldHaveError_When_TypeID_IsLessThanOrEqualToZero()
        {
            var model = new MedicineType { TypeID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.TypeID);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsEmpty()
        {
            var model = new MedicineType { Description = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.Description);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsTooShort()
        {
            var model = new MedicineType { Description = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.Description);
        }

        [Fact]
        public void ShouldHaveError_When_Description_IsTooLong()
        {
            var model = new MedicineType { Description = new string('a', 401) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.Description);
        }

        [Fact]
        public void ShouldHaveError_When_SideEffects_IsEmpty()
        {
            var model = new MedicineType { SideEffects = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.SideEffects);
        }

        [Fact]
        public void ShouldHaveError_When_SideEffects_IsTooShort()
        {
            var model = new MedicineType { SideEffects = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.SideEffects);
        }

        [Fact]
        public void ShouldHaveError_When_SideEffects_IsTooLong()
        {
            var model = new MedicineType { SideEffects = new string('a', 101) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.SideEffects);
        }

        [Fact]
        public void ShouldHaveError_When_Warning_IsEmpty()
        {
            var model = new MedicineType { Warning = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.Warning);
        }

        [Fact]
        public void ShouldHaveError_When_Warning_IsTooShort()
        {
            var model = new MedicineType { Warning = "ab" };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.Warning);
        }

        [Fact]
        public void ShouldHaveError_When_Warning_IsTooLong()
        {
            var model = new MedicineType { Warning = new string('a', 101) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.Warning);
        }

        [Fact]
        public void ShouldHaveError_When_ExpirationDate_IsEmpty()
        {
            var model = new MedicineType { ExpirationDate = null };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.ExpirationDate);
        }

        [Fact]
        public void ShouldHaveError_When_ExpirationDate_IsInThePast()
        {
            var model = new MedicineType { ExpirationDate = DateTime.Now.AddDays(-1) };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(medicineType => medicineType.ExpirationDate);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new MedicineType
            {
                ID = 1,
                MedicineID = 1,
                TypeID = 1,
                Description = "Valid Description",
                SideEffects = "Valid SideEffects",
                Warning = "Valid Warning",
                ExpirationDate = DateTime.Now.AddDays(1)
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(medicineType => medicineType.ID);
            result.ShouldNotHaveValidationErrorFor(medicineType => medicineType.MedicineID);
            result.ShouldNotHaveValidationErrorFor(medicineType => medicineType.TypeID);
            result.ShouldNotHaveValidationErrorFor(medicineType => medicineType.Description);
            result.ShouldNotHaveValidationErrorFor(medicineType => medicineType.SideEffects);
            result.ShouldNotHaveValidationErrorFor(medicineType => medicineType.Warning);
            result.ShouldNotHaveValidationErrorFor(medicineType => medicineType.ExpirationDate);
        }
    }
}