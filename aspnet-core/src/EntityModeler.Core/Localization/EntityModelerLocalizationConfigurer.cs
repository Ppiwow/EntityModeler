using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace EntityModeler.Localization
{
    public static class EntityModelerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(EntityModelerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(EntityModelerLocalizationConfigurer).GetAssembly(),
                        "EntityModeler.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
