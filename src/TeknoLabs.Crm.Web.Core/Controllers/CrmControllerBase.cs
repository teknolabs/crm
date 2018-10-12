using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TeknoLabs.Crm.Controllers
{
    public abstract class CrmControllerBase: AbpController
    {
        protected CrmControllerBase()
        {
            LocalizationSourceName = CrmConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
