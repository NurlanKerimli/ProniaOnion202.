using ProniaOnion202.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Abstraction.Repositories
{
	public interface IRepository<T> where T:BaseEntity, new()
	{
		IQueryable<T> GetAll(Expression<Func<T,bool>>? expression=null,Expression<Func<T,object>>? orderExpression=null, bool isDescending=false,int skip=0,int take=0,bool isTracking = false, params string[] includes);
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T entity);
		void Update (T entity);
		void Delete(T entity);
		Task SaveChangeAsync();
	}
}
