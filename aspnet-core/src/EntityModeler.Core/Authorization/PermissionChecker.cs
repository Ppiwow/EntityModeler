using Abp.Authorization;
using EntityModeler.Authorization.Roles;
using EntityModeler.Authorization.Users;

namespace EntityModeler.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
