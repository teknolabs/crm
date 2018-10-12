using Abp.AutoMapper;
using TeknoLabs.Crm.Roles.Dto;
using TeknoLabs.Crm.Web.Models.Common;

namespace TeknoLabs.Crm.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public EditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }

        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
