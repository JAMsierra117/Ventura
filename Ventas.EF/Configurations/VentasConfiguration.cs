using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.EF.Configurations
{
    public class VentasConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder
               .ToTable("Ventas")
               .HasKey(k => k.ID_Venta);
            
            builder
               .Property(x => x.Importe)
               .HasColumnType("decimal(18,2)");

            builder
               .Property(x => x.Descuento)
               .HasColumnType("decimal(18,2)");

            builder
               .Property(x => x.SubTotal)
               .HasColumnType("decimal(18,2)");

            builder
               .Property(x => x.Impuesto)
               .HasColumnType("decimal(18,2)");

            builder
               .Property(x => x.Total)
               .HasColumnType("decimal(18,2)");
        }
    }
}
