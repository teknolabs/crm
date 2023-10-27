using TeknoLabs.Crm.Presentation;

namespace TeknoLabs.Crm.WebApi.Configurations;

public class PresentationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers().AddApplicationPart(typeof(AssemblyReferance).Assembly);
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}
