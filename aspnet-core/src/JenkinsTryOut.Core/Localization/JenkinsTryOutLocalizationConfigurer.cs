using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace JenkinsTryOut.Localization
{
    public static class JenkinsTryOutLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(JenkinsTryOutConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(JenkinsTryOutLocalizationConfigurer).GetAssembly(),
                        "JenkinsTryOut.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
