using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace TeknoLabs.Crm.Web.Views
{
    public abstract class CrmRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CrmRazorPage()
        {
            LocalizationSourceName = CrmConsts.LocalizationSourceName;
        }
    }
}
