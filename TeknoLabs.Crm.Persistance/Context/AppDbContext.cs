using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain.AppEntities;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Persistance.Context
{
    public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientUsers> ClientUsers { get; set; }
    }
}
