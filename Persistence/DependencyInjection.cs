﻿using Application.Common.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository;
using System;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();

            //services.Configure<DbConnectionConfig>(options => configuration.GetSection("DbConnection").Bind(options));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
        public static IConfigurationBuilder AddPersistenceJson(this IConfigurationBuilder configuration)
        {
            return configuration.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                .AddJsonFile("appsettings.db.json", optional: false, reloadOnChange: true);
        }
    }
}
