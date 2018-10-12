using Abp.AutoMapper;
using TeknoLabs.Crm.Sessions.Dto;

namespace TeknoLabs.Crm.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
