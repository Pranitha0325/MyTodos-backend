using task.Debugging;

namespace task
{
    public class taskConsts
    {
        public const string LocalizationSourceName = "task";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "07bd3644e5ab417bb258f41bf0013c0d";
    }
}
