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
        private static readonly Func<ClientDbContext, string, Task<T>>
            GetByIdCompiled =
            EF.CompileAsyncQuery((ClientDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(p => p.Id == id));

        private static readonly Func<ClientDbContext, Task<T>>
            GetFirstCompiled =
            EF.CompileAsyncQuery((ClientDbContext context) =>
            context.Set<T>().FirstOrDefault());

        private static readonly Func<ClientDbContext, Expression<Func<T, bool>>, Task<T>>
            GetFirstByExpressionCompiled =
            EF.CompileAsyncQuery((ClientDbContext context, Expression<Func<T, bool>> expression) =>
            context.Set<T>().FirstOrDefault(expression));

        private ClientDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (ClientDbContext)context;
            Entity = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression)
        {
            return await GetFirstByExpressionCompiled(_context, expression);
        }

        public async Task<T> GetById(string id)
        {
            return await GetByIdCompiled(_context, id);
        }

        public async Task<T> GetFirst()
        {
            return await GetFirstCompiled(_context);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Entity.Where(expression);
        }
    }
}

