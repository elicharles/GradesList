using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeList.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GradeList.Data.Repository;

namespace GradeList.Data
{
    public static class DependencyInjection
    {
            public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GradeDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IGradeDbContext>(provider => provider.GetService<GradeDbContext>());



            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
