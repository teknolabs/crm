using FluentValidation;
using MediatR;
using TeknoLabs.Crm.Application;
using TeknoLabs.Crm.Application.Behavior;
namespace TeknoLabs.Crm.WebApi.Configurations;

public class ApplicationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AssemblyReferance).Assembly));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        services.AddValidatorsFromAssembly(typeof(AssemblyReferance).Assembly);
    }
}
