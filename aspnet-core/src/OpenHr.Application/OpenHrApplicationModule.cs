using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OpenHr.Authorization;

namespace OpenHr
{
    [DependsOn(
        typeof(OpenHrCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OpenHrApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OpenHrAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OpenHrApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
