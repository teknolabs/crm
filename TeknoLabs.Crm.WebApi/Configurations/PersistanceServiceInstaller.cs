using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.WebApi.Configurations
{
    public class PersistanceServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TeknoLabsCrmDbContext")));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

            services.AddAutoMapper(typeof(TeknoLabs.Crm.Persistance.AssemblyReferance).Assembly);

        }
    }
}
