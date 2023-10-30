using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using TeknoLabs.Crm.WebApi.OptionSetup;

namespace TeknoLabs.Crm.WebApi.Configurations
{
	public class AuthenticationAndAuthorizationServiceInstaller : IServiceInstaller
	{

        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<JwtOptionSetup>();
            services.ConfigureOptions<JwtBearerOptionSetup>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer();
        }
    }
}

