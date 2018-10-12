using System.Collections.Generic;
using TeknoLabs.Crm.Roles.Dto;

namespace TeknoLabs.Crm.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
