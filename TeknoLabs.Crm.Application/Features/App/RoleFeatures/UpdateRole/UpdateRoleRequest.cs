using MediatR;
using Microsoft.AspNetCore.Identity;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.UpdateRole;

public sealed class UpdateRoleRequest : IRequest<UpdateRoleResponse>
{
    public string Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
}
