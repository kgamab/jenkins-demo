using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JenkinsTryOut.Configuration;

namespace JenkinsTryOut.Web.Startup
{
    [DependsOn(typeof(JenkinsTryOutWebCoreModule))]
    public class JenkinsTryOutWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JenkinsTryOutWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<JenkinsTryOutNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JenkinsTryOutWebMvcModule).GetAssembly());
        }
    }
}
