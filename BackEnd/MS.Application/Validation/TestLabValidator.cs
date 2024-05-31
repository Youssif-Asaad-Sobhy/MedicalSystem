using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class TestLabValidator : AbstractValidator<TestLab>
    {
        public TestLabValidator()
        {
            RuleFor(testLab => testLab.ID)
                .NotEmpty().WithMessage("ID is required")
                .GreaterThan(0).WithMessage("ID must be greater than 0");

            RuleFor(testLab => testLab.TestID)
                .NotEmpty().WithMessage("TestID is required")
                .GreaterThan(0).WithMessage("TestID must be greater than 0");

            RuleFor(testLab => testLab.LabID)
                .NotEmpty().WithMessage("LabID is required")
                .GreaterThan(0).WithMessage("LabID must be greater than 0");

            RuleFor(testLab => testLab.Price)
                .GreaterThanOrEqualTo(0).WithMessage("Price must be non-negative");

            RuleFor(testLab => testLab.Description)
                .NotEmpty().WithMessage("Description is required")
                .MaximumLength(200).WithMessage("Description cannot exceed 200 characters");
        }
    }
}
