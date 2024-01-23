using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class AttachmentDocumentsValidator:AbstractValidator<AttachmentDocuments>
    {
        public AttachmentDocumentsValidator() 
        {
            RuleFor(ad => ad.ID).NotEmpty().WithMessage("ID is required.");

            RuleFor(ad => ad.Content).NotEmpty().WithMessage("Content is required.")
                                     .Must(HaveMinimumContentLength).WithMessage("Content must have a minimum length.");

        }

        private bool HaveMinimumContentLength(byte[] content)
        {
            // Example: Ensure that content has a minimum length (adjust as needed)
            return content != null && content.Length > 0;
        }
    }
}