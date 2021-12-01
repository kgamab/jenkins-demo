using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JenkinsTryOut.Authorization;

namespace JenkinsTryOut
{
    [DependsOn(
        typeof(JenkinsTryOutCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class JenkinsTryOutApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<JenkinsTryOutAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(JenkinsTryOutApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
