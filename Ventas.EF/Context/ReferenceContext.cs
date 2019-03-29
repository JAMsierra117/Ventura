using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;
using Ventas.EF.Configurations;

namespace Ventas.EF.Context
{
    public class ReferenceContext : DbContext
    {
        public ReferenceContext(DbContextOptions<ReferenceContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Generales");
            builder.ApplyConfiguration(new ProdutosConfiguration());

        }


    }
}
