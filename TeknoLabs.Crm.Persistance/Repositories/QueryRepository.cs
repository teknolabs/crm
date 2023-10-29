using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using TeknoLabs.Crm.Domain.Abstract;
using TeknoLabs.Crm.Domain.Repositories;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.Persistance.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T>
        where T : Entity
    {
        private static readonly Func<ClientDbContext, string, bool, Task<T>>
            GetByIdCompiled =
            EF.CompileAsyncQuery((ClientDbContext context, string id, bool isTracking) =>
            isTracking ? context.Set<T>().FirstOrDefault(p => p.Id == id)
            : context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id));

        private static readonly Func<ClientDbContext, bool, Task<T>>
            GetFirstCompiled =
            EF.CompileAsyncQuery((ClientDbContext context, bool isTracking) =>
            isTracking ? context.Set<T>().FirstOrDefault()
            : context.Set<T>().AsNoTracking().FirstOrDefault());

        private static readonly Func<ClientDbContext, Expression<Func<T, bool>>, bool, Task<T>>
            GetFirstByExpressionCompiled =
            EF.CompileAsyncQuery((ClientDbContext context, Expression<Func<T, bool>> expression, bool isTracking) =>
            isTracking ? context.Set<T>().FirstOrDefault(expression)
            : context.Set<T>().AsNoTracking().FirstOrDefault(expression));

        private ClientDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (ClientDbContext)context;
            Entity = _context.Set<T>();
        }

        public IQueryable<T> GetAll(bool isTracking = true)
        {
            var result = Entity.AsQueryable();
            if (!isTracking) result = result.AsNoTracking();
            return result;
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            return await GetFirstByExpressionCompiled(_context, expression, isTracking);
        }

        public async Task<T> GetById(string id, bool isTracking = true)
        {
            return await GetByIdCompiled(_context, id, isTracking);
        }

        public async Task<T> GetFirst(bool isTracking = true)
        {
            return await GetFirstCompiled(_context, isTracking);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            var result = Entity.Where(expression);
            if (!isTracking) result = result.AsNoTracking();
            return result;
        }
    }
}

