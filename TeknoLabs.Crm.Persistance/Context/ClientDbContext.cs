using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TeknoLabs.Crm.Domain.AppEntities;

namespace TeknoLabs.Crm.Persistance.Context
{
    public sealed class ClientDbContext : DbContext
    {
        public string ConnectionString { get; set; }
        public ClientDbContext(Client client = null)
        {
            if (client != null)
            {
                if (client.UserId != "")
                    ConnectionString = $"Data Source={client.ServerName};" +
                        $"Initial Catalog={client.DatabaseName};" +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"Trust Server Certificate=False;" +
                        $"Application Intent=ReadWrite;" +
                        $"Multi Subnet Failover=False";
                else
                    ConnectionString = $"Data Source={client.ServerName};" +
                        $"Initial Catalog={client.DatabaseName};" +
                        $"User Id={client.UserId};" +
                        $"Password={client.Password};" +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"Trust Server Certificate=False;" +
                        $"Application Intent=ReadWrite;" +
                        $"Multi Subnet Failover=False";
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReferance).Assembly);

        public class ClientDbContextFactory : IDesignTimeDbContextFactory<ClientDbContext>
        {
            public ClientDbContext CreateDbContext(string[] args)
            {
                return new ClientDbContext();
            }
        }
    }
}
