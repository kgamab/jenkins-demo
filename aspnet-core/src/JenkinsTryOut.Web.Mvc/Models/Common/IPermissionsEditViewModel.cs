using System.Collections.Generic;
using JenkinsTryOut.Roles.Dto;

namespace JenkinsTryOut.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}