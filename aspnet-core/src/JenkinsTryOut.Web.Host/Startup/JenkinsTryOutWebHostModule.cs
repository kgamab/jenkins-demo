using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JenkinsTryOut.Configuration;

namespace JenkinsTryOut.Web.Host.Startup
{
    [DependsOn(
       typeof(JenkinsTryOutWebCoreModule))]
    public class JenkinsTryOutWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JenkinsTryOutWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JenkinsTryOutWebHostModule).GetAssembly());
        }
    }
}
