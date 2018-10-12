using System.Collections.Generic;
using TeknoLabs.Crm.Roles.Dto;

namespace TeknoLabs.Crm.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}