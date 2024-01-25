using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MS.Data.Entities;
using MS.Infrastructure.Validation;

namespace MS.Infrastructure.Validation
{
    public class DocumentsValidator: AbstractValidator<Document>
    {
        public DocumentsValidator()
        {
            RuleFor(d => d.ID).NotEmpty();
            
            RuleFor(d => d.ReportID).NotEmpty().WithMessage("ReportID is required.");

            RuleFor(d => d.AttachmentID).NotEmpty().WithMessage("AttachmentID is required.");
        
        }
    }
}
