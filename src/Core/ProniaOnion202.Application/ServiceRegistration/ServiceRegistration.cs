﻿using Microsoft.Extensions.DependencyInjection;
using ProniaOnion202.Application.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.ServiceRegistration
{
	public class ServiceRegistration
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services )
		{
			services.AddAutoMapper(typeof(CategoryProfile));
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			return services;
		}
	}
}
