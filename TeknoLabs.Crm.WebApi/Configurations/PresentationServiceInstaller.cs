using TeknoLabs.Crm.Presentation;
using TeknoLabs.Crm.WebApi.Middleware;

namespace TeknoLabs.Crm.WebApi.Configurations;

public class PresentationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ExceptionMiddleware>();
        services.AddControllers().AddApplicationPart(typeof(AssemblyReferance).Assembly);
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddAuthentication();
        services.AddAuthorization();
    }
}
