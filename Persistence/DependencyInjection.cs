using Application.Common.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();

            //services.Configure<DbConnectionConfig>(options => configuration.GetSection("DbConnection").Bind(options));
            services.AddScoped<IApplicationContext, ApplicationContext>();
            //services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());

            return services;
        }
        public static IConfigurationBuilder AddPersistenceJson(this IConfigurationBuilder configuration)
        {
            return configuration.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                .AddJsonFile("appsettings.db.json", optional: true, reloadOnChange: true);
        }
    }
}
