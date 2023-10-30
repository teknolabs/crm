
using System;
using TeknoLabs.Crm.Application.Abstractions;
using TeknoLabs.Crm.Infrastructure.Authentication;

namespace TeknoLabs.Crm.WebApi.Configurations
{
	public class InfrastructureDIServiceInstaller : IServiceInstaller
	{
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}

