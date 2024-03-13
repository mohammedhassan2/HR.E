namespace HR.ewb.Lang
{
    public class LanguageSettings
    {
        public static string LanguageType()
        {
            return LanguageSettings.LanguageType("rtl");
        }
        private static string LanguageType(string language)
        {
            return language.ToLower();
        }
    }
}
