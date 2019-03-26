using System;
using System.Collections.Generic;
using System.Text;
using Generales.Core.Models;
using Generales.EF.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Generales.EF.Context
{
    public class GeneralesContext : DbContext
    {
        public GeneralesContext(DbContextOptions<GeneralesContext> options) : base(options)
        {
        }

        public DbSet<Clasificacion> Clasificaciones { get; set; }
        public DbSet<Producto> Productos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClasificacionesConfiguration());
            builder.ApplyConfiguration(new ProductosConfiguration());
        }
    }
}
