using Abp.MultiTenancy;
using TeknoLabs.Crm.Authorization.Users;

namespace TeknoLabs.Crm.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
