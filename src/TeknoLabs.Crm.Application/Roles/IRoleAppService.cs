using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TeknoLabs.Crm.Roles.Dto;

namespace TeknoLabs.Crm.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();

        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);

        Task<ListResultDto<RoleListDto>> GetRolesAsync(GetRolesInput input);
    }
}