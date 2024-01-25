using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class TestsValidator : AbstractValidator<Test>
    {
        public TestsValidator()
        {
            RuleFor(tests => tests.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(tests => tests.Name)
                .NotEmpty()
                .WithMessage("Name is required");
        }
    }
}
