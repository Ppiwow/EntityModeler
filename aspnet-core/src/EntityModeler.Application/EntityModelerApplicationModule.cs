using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EntityModeler.Authorization;

namespace EntityModeler
{
    [DependsOn(
        typeof(EntityModelerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EntityModelerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EntityModelerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EntityModelerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
