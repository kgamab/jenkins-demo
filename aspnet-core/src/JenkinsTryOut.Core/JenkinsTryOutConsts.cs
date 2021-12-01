using JenkinsTryOut.Debugging;

namespace JenkinsTryOut
{
    public class JenkinsTryOutConsts
    {
        public const string LocalizationSourceName = "JenkinsTryOut";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ff73e5a7e8da4cdd95b67cbf3ce9ad67";
    }
}
