using System.Collections.Generic;
using TeknoLabs.Crm.Roles.Dto;
using TeknoLabs.Crm.Users.Dto;

namespace TeknoLabs.Crm.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
