using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.GetAllRoles;

public sealed record GetAllRolesResponse(IList<AppRole> Roles);
