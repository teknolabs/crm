using Abp.Authorization;
using TeknoLabs.Crm.Authorization.Roles;
using TeknoLabs.Crm.Authorization.Users;

namespace TeknoLabs.Crm.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
