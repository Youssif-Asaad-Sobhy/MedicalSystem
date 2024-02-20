using FluentValidation;
using MS.Data.Entities;
using MS.Data.Enums;

namespace MS.Application.Validation
{
    public class PlaceShiftValidator : AbstractValidator<PlaceShift>
    {
        public PlaceShiftValidator()
        {
            RuleFor(placeShift => placeShift.ID)
               .NotEmpty()
               .WithMessage("ID is required")
               .GreaterThan(0)
               .WithMessage("ID must be greater than 0");

            RuleFor(placeShift => placeShift.EntityID)
                .NotEmpty()
                .WithMessage("EntityID is required")
                .GreaterThan(0)
                .WithMessage("EntityID must be greater than 0");

            RuleFor(placeShift => placeShift.PlaceType)
                .IsInEnum().WithMessage("Invalid PlaceType");

            RuleFor(placeShift => placeShift.ShiftID)
                .NotEmpty().WithMessage("ShiftID is required");
        }
    }
}
