using FluentValidation;
using MS.Data.Entities;
using System;
using System.Linq;

namespace MS.Infrastructure.Validation
{
    public class ReportValidator : AbstractValidator<Report>
    {
        public ReportValidator()
        {
            RuleFor(r => r.Time)
                .NotEmpty().WithMessage("Time is required.")
                .Must(BeAValidDateTime).WithMessage("Invalid date and time.");

            RuleFor(r => r.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(255).WithMessage("Description must not exceed 255 characters.");

            RuleFor(r => r.UserID)
                .NotEmpty().WithMessage("UserID is required.");

            RuleFor(r => r.DoctorID)
                .NotEmpty().WithMessage("DoctorID is required.");
        }

        private bool BeAValidDateTime(DateTime dateTime)
        {
            // Example: Ensure that the DateTime is not in the future
            return dateTime <= DateTime.UtcNow;
        }
    }
}
