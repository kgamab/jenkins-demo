﻿using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JenkinsTryOut.EntityFrameworkCore;
using JenkinsTryOut.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace JenkinsTryOut.Web.Tests
{
    [DependsOn(
        typeof(JenkinsTryOutWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class JenkinsTryOutWebTestModule : AbpModule
    {
        public JenkinsTryOutWebTestModule(JenkinsTryOutEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JenkinsTryOutWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(JenkinsTryOutWebMvcModule).Assembly);
        }
    }
}