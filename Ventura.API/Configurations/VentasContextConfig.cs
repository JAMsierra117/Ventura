using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ventas.EF.Context;
using Ventas.EF.Data;

namespace Ventura.API.Configurations
{
    public static class VentasContextConfig
    {
        public static void AddVentasContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VentasContext>(x => x
                   .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                   .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            services.AddDbContext<ReferenceContext>(x => x
                   .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                   .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));


            services.AddScoped<VentasData>();
        }
    }
}
