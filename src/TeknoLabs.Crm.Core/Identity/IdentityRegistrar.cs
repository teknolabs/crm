using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using TeknoLabs.Crm.Authorization;
using TeknoLabs.Crm.Authorization.Roles;
using TeknoLabs.Crm.Authorization.Users;
using TeknoLabs.Crm.Editions;
using TeknoLabs.Crm.MultiTenancy;

namespace TeknoLabs.Crm.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
