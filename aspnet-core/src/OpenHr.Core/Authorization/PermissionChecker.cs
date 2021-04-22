using Abp.Authorization;
using OpenHr.Authorization.Roles;
using OpenHr.Authorization.Users;

namespace OpenHr.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
