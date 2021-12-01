using System.Collections.Generic;
using JenkinsTryOut.Roles.Dto;

namespace JenkinsTryOut.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
