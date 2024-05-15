using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class AttachmentValidator : AbstractValidator<Attachment>
    {
        public AttachmentValidator()
        {
            RuleFor(Attachment => Attachment.FileName)
            .NotEmpty()
            .WithMessage("FileName must not be empty");
            RuleFor(Attachment => Attachment.FolderName)
                .NotEmpty()
                .WithMessage("FolderName must not be empty");
        }
    }
}
