﻿using ProniaOnion202.Application.DTOs.Tokens;
using ProniaOnion202.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Abstraction.Handlers
{
	public interface ITokenHandler
	{
		TokenResponseDto CreateToken(AppUser user,int minutes);
	}
}
