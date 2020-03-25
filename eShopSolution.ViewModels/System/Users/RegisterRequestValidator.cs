using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required")
                .MaximumLength(200).WithMessage("First name has been exceed 200 characters limited.");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required")
               .MaximumLength(200).WithMessage("Last name has been exceed 200 characters limited.");

            RuleFor(x => x.Dob).NotNull().WithMessage("DOB is required")
              .GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("DOB doesn't not allowed if greater than 100 years ago");

            RuleFor(x => x.Email).NotNull().WithMessage("Email is required")
            .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email format is not correct");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("User is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password need to be greater than 8 characters.");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("User is required");

            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.Password != x.ConfirmPassword)
                {
                    context.AddFailure(nameof(x.ConfirmPassword), "Confirmation password is not correct");
                }
            });
        }
    }
}
