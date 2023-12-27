using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProniaOnion202.Application.Abstraction.Repositories;
using ProniaOnion202.Application.Abstraction.Services;
using ProniaOnion202.Application.DTOs.Categories;
using ProniaOnion202.Application.DTOs.Color;
using ProniaOnion202.Application.DTOs.Products;
using ProniaOnion202.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Persistence.Implementations.Services
{
	public class ColorService : IColorService
	{
		private readonly IColorRepository _repository;
		private readonly IMapper _mapper;

		public ColorService(IColorRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<IEnumerable<ColorItemDto>> GetAllAsync(int page, int take)
		{
			ICollection<Color> categories = await _repository.GetAllWhere(skip: (page - 1) * take, take: take, ignoreQuery: true).ToListAsync();
			return _mapper.Map<ICollection<ColorItemDto>>(categories);
		}
		public async Task<ColorGetDto> GetByIdAsync(int id)
		{
			Color product = await _repository.GetByIdAsync(id, includes: nameof(Product.Category));
			if (product is null) throw new Exception("There is no such product");
			return _mapper.Map<ColorGetDto>(product);
		}

		public async Task CreateAsync(ColorCreateDto dto)
		{

			await _repository.AddAsync(_mapper.Map<Color>(dto));
			await _repository.SaveChangeAsync();
		}
		public async Task UpdateAsync(int id, ColorUpdateDto dto)
		{
			Color exist = await _repository.GetByIdAsync(id);
			if (exist is null) throw new Exception("Not Found.");
			exist.Name = dto.Name;
			_repository.Update(exist);
			await _repository.SaveChangeAsync();
		}
		public async Task DeleteAsync(int id)
		{
			Color exist = await _repository.GetByIdAsync(id);
			if (exist is null) throw new Exception("Not Found.");

			_repository.Delete(exist);
			await _repository.SaveChangeAsync();
		}

		public async Task SoftDeleteAsync(int id)
		{
			Color category = await _repository.GetByIdAsync(id, true);
			if (category is null) throw new Exception("Not Found:))");
			_repository.SoftDelete(category);
			await _repository.SaveChangeAsync();
		}
	}
}
