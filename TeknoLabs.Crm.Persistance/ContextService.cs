using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain;
using TeknoLabs.Crm.Domain.AppEntities;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.Persistance
{
    public sealed class ContextService : IContextService
    {
        private readonly AppDbContext _appDbContext;

        public ContextService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbContext CreateDbContextInstance(string clientId)
        {
            Client client = _appDbContext.Set<Client>().Find(clientId);
            return new ClientDbContext(client);
        }
    }
}
