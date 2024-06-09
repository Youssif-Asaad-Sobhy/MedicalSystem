using FluentValidation;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Validation
{
    public class TestResultValidation : AbstractValidator<TestResult>
    {
        public TestResultValidation()
        {
            RuleFor(t => t.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(t => t.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(t => t.TestId).NotEmpty().WithMessage("Test is required");
            RuleFor(t => t.ApplicationUserId).NotEmpty().WithMessage("User is required");
        }
    }
}
