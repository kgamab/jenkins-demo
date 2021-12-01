using System.Collections.Generic;
using JenkinsTryOut.Roles.Dto;

namespace JenkinsTryOut.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
