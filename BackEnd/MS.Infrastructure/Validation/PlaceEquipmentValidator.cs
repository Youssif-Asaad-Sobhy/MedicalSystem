using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MS.Data.Entities;
using MS.Data.Enums;

namespace MS.Infrastructure.Validation
{
    public class PlaceEquipmentValidator : AbstractValidator<PlaceEquipment>
    {
        public PlaceEquipmentValidator()
        {
            RuleFor(pe => pe.ID).NotEmpty().WithMessage("ID is required");

            RuleFor(pe => pe.EquipmentID)
                .NotEmpty().WithMessage("EquipmentID is required");

            RuleFor(pe => pe.EntityID)
                .NotEmpty().WithMessage("EntityID is required");
            
            RuleFor(pe => pe.PlaceType)
                .IsInEnum().WithMessage("Invalid EntityType");

            RuleFor(pe => pe.PlaceType)
                .Must(BeValidEntityType).WithMessage("Invalid EntityType");

        }

        private bool BeValidEntityType(PlaceType entityType)
        {
            // Add custom logic to validate EntityType
            return Enum.IsDefined(typeof(PlaceType), entityType);
        }
    }
}
