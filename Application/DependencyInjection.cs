using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using Application.Common.Interfaces;
using Application.Services;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IProfitSharingCalculatorService, ProfitSharingCalculatorService>();

            return services;
        }
    }
}
