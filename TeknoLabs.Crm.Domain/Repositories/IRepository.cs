using System;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain.Abstract;

namespace TeknoLabs.Crm.Domain.Repositories
{
	public interface IRepository<T>
		where T : Entity
	{
		void CreateDbContextInstance(DbContext context);
		DbSet<T> Entity { get; set; }
	}
}

