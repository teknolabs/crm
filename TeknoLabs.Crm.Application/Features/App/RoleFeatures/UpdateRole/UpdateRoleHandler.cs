using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.UpdateRole;

public sealed class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, UpdateRoleResponse>
{
    private RoleManager<AppRole> _roleManager;

    public UpdateRoleHandler(RoleManager<AppRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
    {
        var role = await _roleManager.FindByIdAsync(request.Id);
        if (role == null) throw new Exception("Role bulunamadı");

        if (role.Code != request.Code)
        {
            AppRole checkRole = await _roleManager.Roles.FirstOrDefaultAsync(k => k.Code == request.Code);
            if (checkRole != null) throw new Exception("Bu kod daha önce kaydedilmiş");
        }

        role.Code = request.Code;
        role.Name = request.Name;
        await _roleManager.UpdateAsync(role);
        return new();
    }
}
