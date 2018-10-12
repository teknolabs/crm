using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TeknoLabs.Crm.Localization
{
    public static class CrmLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CrmConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CrmLocalizationConfigurer).GetAssembly(),
                        "TeknoLabs.Crm.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
