using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OpenHr.EntityFrameworkCore;
using OpenHr.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OpenHr.Web.Tests
{
    [DependsOn(
        typeof(OpenHrWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OpenHrWebTestModule : AbpModule
    {
        public OpenHrWebTestModule(OpenHrEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OpenHrWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OpenHrWebMvcModule).Assembly);
        }
    }
}