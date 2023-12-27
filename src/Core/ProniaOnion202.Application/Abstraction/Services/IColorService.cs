using ProniaOnion202.Application.DTOs.Color;
using ProniaOnion202.Application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Abstraction.Services
{
	public interface IColorService
	{
		Task<IEnumerable<ColorItemDto>> GetAllAsync(int page, int take);
		Task<ColorGetDto> GetByIdAsync(int id);
		Task CreateAsync(ColorCreateDto dto);
		Task UpdateAsync(int id, ColorUpdateDto dto);
		Task DeleteAsync(int id);
	}
}
