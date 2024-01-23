using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class EntityAuthValidator : AbstractValidator<EntityAuth>
    {
        public EntityAuthValidator()
        {
            RuleFor(ea => ea.ID).NotEmpty().WithMessage("ID is required");

            RuleFor(ea => ea.UserID).NotEmpty().WithMessage("UserID is required")
                                 .WithMessage("UserID must be greater than 0");

            RuleFor(ea => ea.EntityType).NotNull().IsInEnum().WithMessage("Invalid EntityType");

            RuleFor(ea => ea.EntityID).NotEmpty().WithMessage("EntityID is required")
                                      .WithMessage("EntityID must be greater than 0");

        }
    }
}