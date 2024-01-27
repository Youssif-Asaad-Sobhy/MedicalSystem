using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            RuleFor(document => document.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(document => document.Content)
                .NotEmpty()
                .WithMessage("Content is required");

            RuleFor(document => document.ReportID)
                .GreaterThan(0)
                .WithMessage("ReportID must be greater than 0");
        }
    }
}
