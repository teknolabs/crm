using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.DeleteRole;

public sealed record DeleteRoleRequest (string Id) : ICommand<DeleteRoleResponse>;