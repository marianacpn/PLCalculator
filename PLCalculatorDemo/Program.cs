using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Persistence;
using Shared.Extensions;
using System;

namespace PLCalculatorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHostBuilder builder = CreateHostBuilder(args);

            IHost host = builder.Build();

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.ConfigureDefaultJson()
                             .AddPersistenceJson();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel((context, options) =>
                    {
                        options.AddServerHeader = false;
                        options.Limits.MaxRequestBodySize = 1073741274;
                        options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(120);
                        options.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(120);
                        options.ListenAnyIP(context.Configuration.GetValue<int>("AppPort"));
                    });
                    webBuilder.UseIIS();
                    webBuilder.UseIISIntegration();
                    webBuilder.UseStartup<Startup>();
                });
    }
}

