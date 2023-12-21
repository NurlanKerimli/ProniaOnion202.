﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProniaOnion202.Application.Abstraction.Services;
using ProniaOnion202.Application.DTOs.Categories;

namespace ProniaOnion202.API.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _service;

		public CategoriesController(ICategoryService service)
        {
			_service = service;
		}
		[HttpGet]
		public async Task<IActionResult> Get(int page,int take)
		{
			return Ok(await _service.GetAllAsync(page, take));
		}
		[HttpPost]
		public async Task<IActionResult> Create([FromForm] CategoryCreateDto categoryDto)
		{
			await _service.Create(categoryDto);
			return StatusCode(StatusCodes.Status201Created);
		}
	}
}
