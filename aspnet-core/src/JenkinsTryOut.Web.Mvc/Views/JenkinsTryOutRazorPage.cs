using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace JenkinsTryOut.Web.Views
{
    public abstract class JenkinsTryOutRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected JenkinsTryOutRazorPage()
        {
            LocalizationSourceName = JenkinsTryOutConsts.LocalizationSourceName;
        }
    }
}
