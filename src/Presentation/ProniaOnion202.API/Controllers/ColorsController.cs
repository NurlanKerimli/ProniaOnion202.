﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProniaOnion202.Application.Abstraction.Services;
using ProniaOnion202.Application.DTOs.Color;
using ProniaOnion202.Application.DTOs.Products;

namespace ProniaOnion202.API.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ColorsController : ControllerBase
	{
		private readonly IColorService _service;

		public ColorsController(IColorService service)
		{
			_service = service;
		}
		[HttpGet]
		public async Task<IActionResult> GetAll(int page, int take)
		{
			return Ok(await _service.GetAllAsync(page, take));
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
			return StatusCode(StatusCodes.Status200OK, await _service.GetByIdAsync(id));
		}
		[HttpPost]
		public async Task<IActionResult> Post(ColorCreateDto dto)
		{
			await _service.CreateAsync(dto);
			return StatusCode(StatusCodes.Status201Created);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, ColorUpdateDto dto)
		{
			if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
			await _service.UpdateAsync(id, dto);
			return StatusCode(StatusCodes.Status204NoContent);

		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
			{
				try
				{
					await _service.DeleteAsync(id);
					return NoContent();
				}
				catch
				{
					
					return BadRequest(new { error = "There was an error while deleting the resource." });
				}
			}	
	}
}
