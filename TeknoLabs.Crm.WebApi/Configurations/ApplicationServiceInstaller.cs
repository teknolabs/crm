using TeknoLabs.Crm.Application;

namespace TeknoLabs.Crm.WebApi.Configurations;

public class ApplicationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AssemblyReferance).Assembly));
    }
}
