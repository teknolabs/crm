using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Application.Services.ClientService;
using TeknoLabs.Crm.Domain.Repositories.UCAFRepositories;
using TeknoLabs.Crm.Domain;
using TeknoLabs.Crm.Persistance.Repositories.UCAFRepositories;
using TeknoLabs.Crm.Persistance.Services.App;
using TeknoLabs.Crm.Persistance.Services.ClientService;
using TeknoLabs.Crm.Persistance;

namespace TeknoLabs.Crm.WebApi.Configurations;

public class PersistanceDIServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IContextService, ContextService>();

        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IUCAFService, UCAFService>();

        services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
        services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
    }
}
