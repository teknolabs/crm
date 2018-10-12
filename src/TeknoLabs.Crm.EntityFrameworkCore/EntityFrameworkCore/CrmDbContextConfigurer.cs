using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TeknoLabs.Crm.EntityFrameworkCore
{
    public static class CrmDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CrmDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CrmDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
