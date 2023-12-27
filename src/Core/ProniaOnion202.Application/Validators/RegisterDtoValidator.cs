﻿using FluentValidation;
using ProniaOnion202.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Validators
{
    public class RegisterDtoValidator:AbstractValidator<RegisterDto>
	{
        public RegisterDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .Matches(@"^[a-zA-Z0-9\s]*$")
                .EmailAddress()
                .MaximumLength(256);
            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(8)
                .MaximumLength(100);
            RuleFor(x=>x.UserName)
                .NotEmpty()
                .MinimumLength(4)
                .MaximumLength(256);
            RuleFor(x=>x.Name)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);
            RuleFor(x => x.Surname)
                .NotEmpty()
                .MinimumLength(3);
            RuleFor(x => x)
                .Must(x => x.ConfirmPassword == x.Password);

		}
    }
}
