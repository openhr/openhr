using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OpenHr.Controllers
{
    public abstract class OpenHrControllerBase: AbpController
    {
        protected OpenHrControllerBase()
        {
            LocalizationSourceName = OpenHrConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
