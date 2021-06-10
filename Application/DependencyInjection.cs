using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using Application.Services;
using Application.Common.Interfaces;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<ICalculatorService, ProfitSharingCalculatorService>();

            return services;
        }
    }
}
