using FluentValidation.TestHelper;
using MS.Application.Validation;
using MS.Data.Entities;
using MS.Data.Enums;
using Xunit;

namespace MS.Application.Tests.Validation
{
    public class ReservationValidatorTests
    {
        private readonly ReservationValidator _validator;

        public ReservationValidatorTests()
        {
            _validator = new ReservationValidator();
        }

        [Fact]
        public void ShouldHaveError_When_ID_IsEmptyOrLessThanOne()
        {
            var model = new Reservation { ID = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reservation => reservation.ID);
        }

        [Fact]
        public void ShouldHaveError_When_Time_IsEmptyOrPast()
        {
            var model = new Reservation { Time = DateTime.Now.AddMinutes(-1) }; // Past time
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reservation => reservation.Time);
        }

        [Fact]
        public void ShouldHaveError_When_UserID_IsEmpty()
        {
            var model = new Reservation { UserID = string.Empty };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reservation => reservation.UserID);
        }

        [Fact]
        public void ShouldHaveError_When_State_IsInvalid()
        {
            var model = new Reservation { State = (ReservationState)999 }; // Invalid enum value
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reservation => reservation.State);
        }

        [Fact]
        public void ShouldHaveError_When_PlacePriceId_IsEmptyOrLessThanOne()
        {
            var model = new Reservation { PlacePriceId = 0 };
            var result = _validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(reservation => reservation.PlacePriceId);
        }

        [Fact]
        public void ShouldNotHaveError_When_AllFieldsAreValid()
        {
            var model = new Reservation
            {
                ID = 1,
                Time = DateTime.Now.AddMinutes(1), // Future time
                UserID = "ValidUserID",
                State = ReservationState.Running, // Assuming Active is a valid enum value
                PlacePriceId = 1
            };
            var result = _validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(reservation => reservation.ID);
            result.ShouldNotHaveValidationErrorFor(reservation => reservation.Time);
            result.ShouldNotHaveValidationErrorFor(reservation => reservation.UserID);
            result.ShouldNotHaveValidationErrorFor(reservation => reservation.State);
            result.ShouldNotHaveValidationErrorFor(reservation => reservation.PlacePriceId);
        }
    }
}