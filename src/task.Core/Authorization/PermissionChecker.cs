using Abp.Authorization;
using task.Authorization.Roles;
using task.Authorization.Users;

namespace task.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
