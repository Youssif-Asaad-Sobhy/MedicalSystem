using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class AttachmentValidator : AbstractValidator<Attachment>
    {
        public AttachmentValidator()
        {
            RuleFor(Attachment => Attachment.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            

            RuleFor(Attachment => Attachment.ReportID)
                .GreaterThan(0)
                .WithMessage("ReportID must be greater than 0");
        }
    }
}
