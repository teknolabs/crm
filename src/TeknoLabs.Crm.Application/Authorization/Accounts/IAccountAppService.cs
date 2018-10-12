using System.Threading.Tasks;
using Abp.Application.Services;
using TeknoLabs.Crm.Authorization.Accounts.Dto;

namespace TeknoLabs.Crm.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
