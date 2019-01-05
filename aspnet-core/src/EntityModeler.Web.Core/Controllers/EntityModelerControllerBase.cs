using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EntityModeler.Controllers
{
    public abstract class EntityModelerControllerBase: AbpController
    {
        protected EntityModelerControllerBase()
        {
            LocalizationSourceName = EntityModelerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
