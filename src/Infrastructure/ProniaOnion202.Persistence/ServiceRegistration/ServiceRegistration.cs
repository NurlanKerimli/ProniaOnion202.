﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProniaOnion202.Application.Abstraction.Repositories;
using ProniaOnion202.Application.Abstraction.Services;
using ProniaOnion202.Persistence.Contexts;
using ProniaOnion202.Persistence.Implementations.Repositories;
using ProniaOnion202.Persistence.Implementations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Persistence.ServiceRegistration
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default"),
				b=>b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)));

			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IColorRepository, ColorRepository>();

			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IProductService, ProductService>();
			return services;
		}
	}
}
