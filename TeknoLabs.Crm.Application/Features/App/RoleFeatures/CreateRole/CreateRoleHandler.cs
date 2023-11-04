using TeknoLabs.Crm.Application.Messaging;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole;

public sealed class CreateRoleHandler : ICommandHandler<CreateRoleRequest, CreateRoleResponse>
{
    private readonly IRoleService _roleService;

    public CreateRoleHandler(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
    {
        AppRole role = await _roleService.GetByCode(request.Code);
        if (role != null) throw new Exception("Bu rol daha önce tanımlanmış");
         
        await _roleService.AddAsync(request);
        return new();
    }
}

