using Abp.AutoMapper;
using JenkinsTryOut.Roles.Dto;
using JenkinsTryOut.Web.Models.Common;

namespace JenkinsTryOut.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
