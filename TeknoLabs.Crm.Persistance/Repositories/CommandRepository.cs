using System;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain.Abstract;
using TeknoLabs.Crm.Domain.Repositories;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.Persistance.Repositories
{
    public class CommandRepository<T> : ICommandRepository<T>
        where T : Entity
    {
        private static readonly Func<ClientDbContext, string, Task<T>>
            GetByIdCompiled =
            EF.CompileAsyncQuery((ClientDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(p => p.Id == id));

        private ClientDbContext _context;
        public DbSet<T> Entity { get; set; }

        public void CreateDbContextInstance(DbContext context)
        {
            _context = (ClientDbContext)context;
            Entity = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Entity.AddRangeAsync(entities);
        }

        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            T entity = await GetByIdCompiled(_context, id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Entity.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            Entity.UpdateRange(entities);
        }
    }
}

