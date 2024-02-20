using FluentValidation;
using MS.Data.Entities;
using MS.Data.Enums;
using System;

namespace MS.Application.Validation
{
    public class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator()
        {
            RuleFor(reservation => reservation.ID)
                .NotEmpty().WithMessage("ID is required")
                .GreaterThan(0).WithMessage("ID must be greater than 0");

            RuleFor(reservation => reservation.Time)
                .NotEmpty().WithMessage("Time is required")
                .Must(BeInTheFuture).WithMessage("Time must be in the future");

            RuleFor(reservation => reservation.UserID)
                .NotEmpty().WithMessage("UserID is required");

            RuleFor(reservation => reservation.State)
                .IsInEnum().WithMessage("Invalid ReservationState");

            RuleFor(reservation => reservation.PlaceType)
                .IsInEnum().WithMessage("Invalid EntityType");

            RuleFor(reservation => reservation.EntityID)
                .NotEmpty().WithMessage("EntityID is required")
                .GreaterThan(0).WithMessage("EntityID must be greater than 0");

            RuleFor(reservation => reservation.Price)
                .GreaterThanOrEqualTo(0).WithMessage("Price must be non-negative");
        }

        // Custom validation method to check if the reservation time is in the future
        private bool BeInTheFuture(DateTime time)
        {
            return time > DateTime.Now;
        }
    }
}
