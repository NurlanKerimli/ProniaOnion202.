﻿using ProniaOnion202.Application.Abstraction.Repositories;
using ProniaOnion202.Domain.Entities;
using ProniaOnion202.Persistence.Contexts;
using ProniaOnion202.Persistence.Implementations.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Persistence.Implementations.Repositories
{
	public class CategoryRepository:Repository<Category>,ICategoryRepository
	{
        public CategoryRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
