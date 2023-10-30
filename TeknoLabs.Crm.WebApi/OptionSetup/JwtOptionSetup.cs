
using System;
using Microsoft.Extensions.Options;
using TeknoLabs.Crm.Infrastructure.Authentication;

namespace TeknoLabs.Crm.WebApi.OptionSetup
{
	public sealed class JwtOptionSetup : IConfigureOptions<JwtOptions>
	{
        private readonly IConfiguration _configuration;
        private const string Jwt = nameof(Jwt);
        public JwtOptionSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(JwtOptions options)
        {
            _configuration.GetSection(Jwt).Bind(options);
        }
    }
}

