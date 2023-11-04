using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole;

public sealed record CreateRoleRequest(string Name, string Code) : ICommand<CreateRoleResponse>;