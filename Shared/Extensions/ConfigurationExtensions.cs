using Microsoft.Extensions.Configuration;
using System;

namespace Shared.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IConfigurationBuilder ConfigureDefaultJson(this IConfigurationBuilder configuration)
        {
            return configuration.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }
    }
}
