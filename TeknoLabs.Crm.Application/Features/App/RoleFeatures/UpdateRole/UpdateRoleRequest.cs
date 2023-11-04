using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.UpdateRole;

public sealed record UpdateRoleRequest(
    string Id,
    string Code,
    string Name) : ICommand<UpdateRoleResponse>;