using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.Persistance
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private ClientDbContext _context;
        public void SetDbContextInstance(DbContext context)
        {
            _context = (ClientDbContext)context;
        }

        public async Task<int> SaveChangesAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count;
        }
    }
}
