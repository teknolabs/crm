using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.GetAllRoles;

public sealed record GetAllRolesRequest() : IQuery<GetAllRolesResponse>;

