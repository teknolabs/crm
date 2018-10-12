using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TeknoLabs.Crm.Roles.Dto;
using TeknoLabs.Crm.Users.Dto;

namespace TeknoLabs.Crm.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
