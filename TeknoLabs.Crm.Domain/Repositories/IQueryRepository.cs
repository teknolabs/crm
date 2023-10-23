using System;
using System.Linq.Expressions;
using TeknoLabs.Crm.Domain.Abstract;

namespace TeknoLabs.Crm.Domain.Repositories
{
	public interface IQueryRepository<T> : IRepository<T>
		where T : Entity
	{
		IQueryable<T> GetAll();
		IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
		Task<T> GetById(string id);
		Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression);
		Task<T> GetFirst();
	}
}

