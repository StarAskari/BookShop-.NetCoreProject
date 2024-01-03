using BookShop.Application.DtoModels;
using BookShop.Application.Interfaces;
using BookShop.Domain.Common;
using BookShop.Domain.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookShop.Application.FluentValidations
{
    public class UserFluentValidation:AbstractValidator<UserDTO>
    {
        private IUserService _UserService;
        public UserFluentValidation(IUserService userService) {
            _UserService= userService;
            RuleFor(user => user.UserName).NotEmpty().WithMessage("UerName should not be Empty")
                .Must(BeUniqueUserName).WithMessage("The userName is not Unique");
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email should not be empty").Matches(new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")).WithMessage("Incorrect Email Format");
            RuleFor(user => user.ConfirmedEmail).NotEmpty().WithMessage("ConfirmedEmail should not be empty").Equal(user => user.Email, StringComparer.Ordinal).WithMessage("ConfirmedEmail does not match with Email")
                .Matches(new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")).WithMessage("Incorrect Email Format");
            RuleFor(p => p.PasswordHash).NotEmpty().WithMessage("Your password cannot be empty")
               .MinimumLength(8).WithMessage("Your password length must be at least 8.")
               .MaximumLength(16).WithMessage("Your password length must not exceed 16.")
               .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
               .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
               .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.")
               .Matches(@"[\!\?\*\.]+").WithMessage("Your password must contain at least one (!? *.).");
            RuleFor(p => p.PhoneNumber)
           .NotEmpty()
           .NotNull().WithMessage("Phone Number is required.");
        }

     

        private bool BeUniqueUserName(string userName)
        {
            return !_UserService.Find(v => v.UserName == userName && v.IsActive==EnumActiveOrNot.Active).Any();
        }
    }
}
