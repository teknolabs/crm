using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using TeknoLabs.Crm.Authorization.Users;
using TeknoLabs.Crm.Editions;

namespace TeknoLabs.Crm.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
