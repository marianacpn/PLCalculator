using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Persistence
{
    public static class DependencyInjection
    {

        public static IConfigurationBuilder AddPersistenceJson(this IConfigurationBuilder configuration)
        {

            return configuration.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                .AddJsonFile("appsettings.db.json", optional: true, reloadOnChange: true);
        }
    }
}
