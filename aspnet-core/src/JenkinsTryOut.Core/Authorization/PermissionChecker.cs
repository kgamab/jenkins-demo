using Abp.Authorization;
using JenkinsTryOut.Authorization.Roles;
using JenkinsTryOut.Authorization.Users;

namespace JenkinsTryOut.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
