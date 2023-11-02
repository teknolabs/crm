using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.GetAllRoles;

public sealed class GetAllRolesResponse
{
    public IList<AppRole> Roles { get; set; }

}
