using System.Threading.Tasks;
using Abp.Application.Services;
using TeknoLabs.Crm.Sessions.Dto;

namespace TeknoLabs.Crm.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
