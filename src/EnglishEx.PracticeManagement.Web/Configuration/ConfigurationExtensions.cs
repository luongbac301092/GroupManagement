using Microsoft.Extensions.Configuration;

namespace EnglishEx.PracticeManagement.Web.Configuration
{
    public static class ConfigurationExtensions
    {
        public static T GetSection<T>(this IConfiguration configuration, string key)
            => configuration.GetSection(key).Get<T>();

    }
}
