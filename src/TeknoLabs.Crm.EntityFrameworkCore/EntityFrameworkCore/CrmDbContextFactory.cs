using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TeknoLabs.Crm.Configuration;
using TeknoLabs.Crm.Web;

namespace TeknoLabs.Crm.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CrmDbContextFactory : IDesignTimeDbContextFactory<CrmDbContext>
    {
        public CrmDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CrmDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CrmDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CrmConsts.ConnectionStringName));

            return new CrmDbContext(builder.Options);
        }
    }
}
