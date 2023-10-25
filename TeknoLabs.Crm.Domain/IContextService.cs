using Microsoft.EntityFrameworkCore;

namespace TeknoLabs.Crm.Domain
{
    public interface IContextService
    {
        DbContext CreateDbContextInstance(string clientId);
    }
}
