using ProniaOnion202.Application.DTOs.Categories;
using ProniaOnion202.Application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Abstraction.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<CategoryItemDto>> GetAllAsync(int page, int take);
		Task<CategoryGetDto> GetByIdAsync(int id);
		Task CreateAsync(CategoryCreateDto dto);
		Task UpdateAsync(int id, CategoryUpdateDto dto);
		Task DeleteAsync(int id);
		Task SoftDeleteAsync(int id);
	}
}
