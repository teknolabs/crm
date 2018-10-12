using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TeknoLabs.Crm.Authorization.Roles;
using TeknoLabs.Crm.Authorization.Users;
using TeknoLabs.Crm.MultiTenancy;

namespace TeknoLabs.Crm.EntityFrameworkCore
{
    public class CrmDbContext : AbpZeroDbContext<Tenant, Role, User, CrmDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CrmDbContext(DbContextOptions<CrmDbContext> options)
            : base(options)
        {
        }
    }
}
