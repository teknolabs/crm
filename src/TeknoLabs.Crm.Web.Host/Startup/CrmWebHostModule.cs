using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TeknoLabs.Crm.Configuration;

namespace TeknoLabs.Crm.Web.Host.Startup
{
    [DependsOn(
       typeof(CrmWebCoreModule))]
    public class CrmWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CrmWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CrmWebHostModule).GetAssembly());
        }
    }
}
