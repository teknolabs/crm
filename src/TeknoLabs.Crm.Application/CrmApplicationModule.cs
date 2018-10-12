using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TeknoLabs.Crm.Authorization;

namespace TeknoLabs.Crm
{
    [DependsOn(
        typeof(CrmCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CrmApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CrmAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CrmApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
