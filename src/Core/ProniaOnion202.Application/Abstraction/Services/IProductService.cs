﻿using ProniaOnion202.Application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Abstraction.Services
{
	public interface IProductService
	{
		Task<IEnumerable<ProductItemDto>> GetAllAsync(int page, int take);
	}
}