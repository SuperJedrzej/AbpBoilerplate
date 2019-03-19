using Abp.Authorization;
using ExampleProject.Authorization.Roles;
using ExampleProject.Authorization.Users;

namespace ExampleProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
