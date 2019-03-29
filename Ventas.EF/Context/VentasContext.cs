using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;
using Ventas.EF.Configurations;

namespace Ventas.EF.Context
{
    public class VentasContext : DbContext
    {
        public VentasContext(DbContextOptions<VentasContext> options) : base(options)
        {
            
        }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<VentaDetalle> VentasDetalles { get; set; }
        
        public DbSet<VentaPago> VentasPagos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new VentasConfiguration());

            builder.ApplyConfiguration(new VentasDetallesConfiguration());

            builder.ApplyConfiguration(new VentasPagosConfiguration());
            
        }
    }
}
