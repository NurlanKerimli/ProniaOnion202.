using FluentValidation;
using FluentValidation.Validators;
using ProniaOnion202.Application.DTOs.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Validators.Color
{
	internal class ColorCreateDtoValidator:AbstractValidator<ColorCreateDto>
	{
        public ColorCreateDtoValidator()
        {
			RuleFor(x => x.Name).NotEmpty().MaximumLength(50).Matches(@"^[a-zA-Z0-9\s]*$").MinimumLength(3);
		}
    }
}
