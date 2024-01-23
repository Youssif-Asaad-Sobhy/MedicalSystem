using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class TestLabValidator : AbstractValidator<TestLab>
    {
        public TestLabValidator()
        {
            RuleFor(x => x.ID)
                .NotEmpty()
                .NotNull();
            RuleFor(x=>x.TestID)
                .NotEmpty()
                .NotNull();
            RuleFor(x=>x.LabID)
                .NotEmpty()
                .NotNull();
            RuleFor(x=>x.Price)
                .NotEmpty()
                .NotNull()
                .LessThan(100000)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(10000)
                .NotNull();
        }
    }
}
