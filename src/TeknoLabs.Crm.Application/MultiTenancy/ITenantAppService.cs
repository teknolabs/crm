using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TeknoLabs.Crm.MultiTenancy.Dto;

namespace TeknoLabs.Crm.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
