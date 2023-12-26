using FluentValidation;
using ProniaOnion202.Application.DTOs.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Validators.Color
{
	internal class ColorUpdateDtoValidator:AbstractValidator<ColorUpdateDto>
	{
        public ColorUpdateDtoValidator()
        {
			RuleFor(x => x.Name)
			.NotEmpty().WithMessage("Name is Important.")
			.MaximumLength(15).WithMessage("Name may consist maximum 15 characters")
			.MinimumLength(3).WithMessage("Name may consist at least 3 characters");
		}
    }
}
