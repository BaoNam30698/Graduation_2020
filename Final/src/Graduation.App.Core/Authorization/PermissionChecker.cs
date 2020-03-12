using Abp.Authorization;
using Graduation.App.Authorization.Roles;
using Graduation.App.Authorization.Users;

namespace Graduation.App.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
