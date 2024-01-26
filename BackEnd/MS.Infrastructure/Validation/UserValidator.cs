using FluentValidation;
using MS.Data.Entities;
using System.Text.RegularExpressions;

namespace MS.Infrastructure.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.ID)
                .GreaterThan(0)
                .WithMessage("ID must be greater than 0");

            RuleFor(user => user.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(100)
                .WithMessage("Name cannot be longer than 100 characters");

            RuleFor(user => user.Email)
                .NotEmpty()
                .WithMessage("Email is required")
                .EmailAddress()
                .WithMessage("Invalid email format");

            RuleFor(user => user.Phone)
                .NotEmpty()
                .WithMessage("Phone is required")
                .Matches(@"^\d{10}$")
                .WithMessage("Phone must be a 10-digit number");

            RuleFor(user => user.password)
                .NotEmpty()
                .WithMessage("Password is required")
                .MinimumLength(8)
                .WithMessage("Password must be at least 8 characters long")
                .Must(ContainUppercaseLetter)
                .WithMessage("Password must contain at least one uppercase letter")
                .Must(ContainLowercaseLetter)
                .WithMessage("Password must contain at least one lowercase letter")
                .Must(ContainDigit)
                .WithMessage("Password must contain at least one digit")
                .Must(ContainSpecialCharacter)
                .WithMessage("Password must contain at least one special character")
                .Must(password => !password.Contains(" "))
                .WithMessage("Password cannot contain spaces");

            RuleFor(user => user.NID)
              .NotEmpty()
              .WithMessage("NID is required")
              .Length(14)
              .WithMessage("NID must be a 14-digit number");


            RuleFor(user => user.Gender)
                .NotEmpty()
                .WithMessage("Gender is required")
                .Must(gender => gender.ToLower() == "male" || gender.ToLower() == "female")
                .WithMessage("Invalid gender");

            RuleFor(user => user.BirthDate)
                .NotEmpty()
                .WithMessage("BirthDate is required")
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
