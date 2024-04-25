using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class AttachmentValidator : AbstractValidator<Attachment>
    {
        public AttachmentValidator()
        {
            RuleFor(document => document.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            

            RuleFor(document => document.ReportID)
                .GreaterThan(0)
                .WithMessage("ReportID must be greater than 0");
        }
    }
}
