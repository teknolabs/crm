using TeknoLabs.Crm.Application.Messaging;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.GetAllRoles;


public sealed class GetAllRolesHandler : IQueryHandler<GetAllRolesRequest, GetAllRolesResponse>
{
    private readonly IRoleService _roleService;

    public GetAllRolesHandler(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<GetAllRolesResponse> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
    {
        IList<AppRole> roles = await _roleService.GetAllRolesAsync();
        return new(roles);
    }
}
