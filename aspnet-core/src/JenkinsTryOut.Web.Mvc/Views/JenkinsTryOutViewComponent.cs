using Abp.AspNetCore.Mvc.ViewComponents;

namespace JenkinsTryOut.Web.Views
{
    public abstract class JenkinsTryOutViewComponent : AbpViewComponent
    {
        protected JenkinsTryOutViewComponent()
        {
            LocalizationSourceName = JenkinsTryOutConsts.LocalizationSourceName;
        }
    }
}
