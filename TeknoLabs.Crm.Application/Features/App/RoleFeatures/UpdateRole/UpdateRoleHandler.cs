using TeknoLabs.Crm.Application.Messaging;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.UpdateRole;

public sealed class UpdateRoleHandler : ICommandHandler<UpdateRoleRequest, UpdateRoleResponse>
{
    private readonly IRoleService _roleService;

    public UpdateRoleHandler(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
    {
        var role = await _roleService.GetById(request.Id);
        if (role == null) throw new Exception("Role bulunamadı");

        if (role.Code != request.Code)
        {
            AppRole checkRole = await _roleService.GetByCode(request.Code);
            if (checkRole != null) throw new Exception("Bu kod daha önce kaydedilmiş");
        }

        role.Code = request.Code;
        role.Name = request.Name;
        await _roleService.UpdateAsync(role);
        return new();
    }
}
