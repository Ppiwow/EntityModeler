using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EntityModeler.Configuration;

namespace EntityModeler.Web.Host.Startup
{
    [DependsOn(
       typeof(EntityModelerWebCoreModule))]
    public class EntityModelerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EntityModelerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EntityModelerWebHostModule).GetAssembly());
        }
    }
}
