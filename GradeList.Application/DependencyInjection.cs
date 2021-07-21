using System;
using GradeList.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GradeList.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
           

            services.AddScoped(typeof(IGradeBL), typeof(IGradeBL));

            return services;
        }
    }
}
