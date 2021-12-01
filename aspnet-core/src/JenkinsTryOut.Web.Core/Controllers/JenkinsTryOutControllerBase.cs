using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace JenkinsTryOut.Controllers
{
    public abstract class JenkinsTryOutControllerBase: AbpController
    {
        protected JenkinsTryOutControllerBase()
        {
            LocalizationSourceName = JenkinsTryOutConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
