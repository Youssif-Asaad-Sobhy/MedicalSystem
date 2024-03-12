using FluentValidation;
using MS.Data.Entities;
using System.Text.RegularExpressions;

namespace MS.Application.Validation
{
    public class UserValidator : AbstractValidator<ApplicationUser>
    {
        public UserValidator()
        {
            RuleFor(user => user.Id)
                .NotNull()
                .WithMessage("ID is a must ");


            RuleFor(user => user.Email)
                .EmailAddress()
                .WithMessage("Invalid email format");
            
            
            RuleFor(user => user.NID)
              .NotEmpty()
              .WithMessage("NID is required")
              .Length(14)
              .WithMessage("NID must be a 14-digit number");


            RuleFor(user => user.Gender)
                .Must(gender => gender.ToLower() == "male" || gender.ToLower() == "female")
                .WithMessage("Invalid gender");

            RuleFor(user => user.BirthDate)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("BirthDate cannot be in the future");

        }

        private bool ContainUppercaseLetter(string password)
        {
            return Regex.IsMatch(password, @"[A-Z]");
        }

        private bool ContainLowercaseLetter(string password)
        {
            return Regex.IsMatch(password, @"[a-z]");
        }

        private bool ContainDigit(string password)
        {
            return Regex.IsMatch(password, @"\d");
        }

        private bool ContainSpecialCharacter(string password)
        {
            return Regex.IsMatch(password, @"[^A-Za-z0-9]");
        }
    }
}
