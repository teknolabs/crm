using MediatR;
using Microsoft.AspNetCore.Identity;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.DeleteRole;

public sealed class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, DeleteRoleResponse>
{
    private readonly RoleManager<AppRole> _roleManager;

    public DeleteRoleHandler(RoleManager<AppRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task<DeleteRoleResponse> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
    {
        AppRole role = await _roleManager.FindByIdAsync(request.Id);
        if (role == null) throw new Exception("Role bulunamadı!");
        await _roleManager.DeleteAsync(role);
        return new();
    }
}
