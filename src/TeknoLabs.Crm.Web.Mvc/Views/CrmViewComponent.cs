using Abp.AspNetCore.Mvc.ViewComponents;

namespace TeknoLabs.Crm.Web.Views
{
    public abstract class CrmViewComponent : AbpViewComponent
    {
        protected CrmViewComponent()
        {
            LocalizationSourceName = CrmConsts.LocalizationSourceName;
        }
    }
}
