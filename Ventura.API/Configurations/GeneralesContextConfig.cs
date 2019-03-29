using Generales.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ventura.API.Configurations
{
    public static class GeneralesContextConfig
    {
        public static void AddGeneralesContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Bind options using a sub-section of the appsettings.json file.        
            services
               .AddDbContext<GeneralesContext>(x => x
                   .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                   .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        }
    }
}
