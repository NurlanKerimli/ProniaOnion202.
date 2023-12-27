using FluentValidation;
using ProniaOnion202.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Validators
{
	public class LoginDtoValidator:AbstractValidator<LoginDto>
	{
        public LoginDtoValidator()
        {
			RuleFor(x => x.UserNameOrEmail)
			   .NotEmpty()
			   .Matches(@"^[a-zA-Z0-9\s]*$")
			   .EmailAddress()
			   .MinimumLength(6)
			   .MaximumLength(256);
			RuleFor(x => x.Password)
				.NotEmpty()
				.MinimumLength(8)
				.MaximumLength(100);
		}
    }
}
