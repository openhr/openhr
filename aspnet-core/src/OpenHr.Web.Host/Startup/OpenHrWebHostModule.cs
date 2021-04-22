using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OpenHr.Configuration;

namespace OpenHr.Web.Host.Startup
{
    [DependsOn(
       typeof(OpenHrWebCoreModule))]
    public class OpenHrWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OpenHrWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OpenHrWebHostModule).GetAssembly());
        }
    }
}
