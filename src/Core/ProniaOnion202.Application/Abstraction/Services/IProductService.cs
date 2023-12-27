using ProniaOnion202.Application.DTOs.Categories;
using ProniaOnion202.Application.DTOs.Color;
using ProniaOnion202.Application.DTOs.Products;
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
		Task<ProductGetDto> GetByIdAsync(int id);
		Task CreateAsync(ProductCreateDto dto);
		Task UpdateAsync(int id,ProductUpdateDto dto);
		Task DeleteAsync(int id);
		

		
	}
}
