using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JenkinsTryOut.Configuration;
using JenkinsTryOut.EntityFrameworkCore;
using JenkinsTryOut.Migrator.DependencyInjection;

namespace JenkinsTryOut.Migrator
{
    [DependsOn(typeof(JenkinsTryOutEntityFrameworkModule))]
    public class JenkinsTryOutMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public JenkinsTryOutMigratorModule(JenkinsTryOutEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(JenkinsTryOutMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                JenkinsTryOutConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JenkinsTryOutMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
