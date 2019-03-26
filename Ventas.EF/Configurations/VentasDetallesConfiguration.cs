using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.EF.Configurations
{
    public class VentasDetallesConfiguration : IEntityTypeConfiguration<VentaDetalle>
    {
        public void Configure(EntityTypeBuilder<VentaDetalle> builder)
        {
            builder
              .ToTable("VentasDetalles", "Ventas")
              .HasKey(k => k.ID_VentaDetalle);

            builder
               .Property(x => x.PrecioUnitario)
               .HasColumnType("decimal(18,6)");

            builder
               .Property(x => x.Cantidad)
               .HasColumnType("decimal(18,6)");

            builder
                .Property(x => x.Importe)
                .HasColumnType("decimal(18,6)");

            builder
                .Property(x => x.Descuento)
                .HasColumnType("decimal(18,6)");

            builder
                .Property(x => x.PorcentajeDescuento)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(x => x.Impuesto)
                .HasColumnType("decimal(18,6)");

            builder
                .Property(x => x.PorcentajeImpuesto)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(x => x.SubTotal)
                .HasColumnType("decimal(18,6)");

            builder
                .Property(x => x.Total)
                .HasColumnType("decimal(18,6)");


            builder
                .HasOne(u => u.Venta)
                .WithMany(u => u.VentaDetalles)
                .HasForeignKey(u => u.ID_VentaDetalle)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
