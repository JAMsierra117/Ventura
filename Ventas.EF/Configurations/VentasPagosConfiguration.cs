using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ventas.Core.Models;

namespace Ventas.EF.Configurations
{
    public class VentasPagosConfiguration : IEntityTypeConfiguration<VentaPago>
    {
        public void Configure(EntityTypeBuilder<VentaPago> builder)
        {
            builder
               .ToTable("VentasPagos", "Ventas")
               .HasKey(k => k.ID_VentaPago);

            builder
               .Property(x => x.Importe)
               .HasColumnType("decimal(18,2)");

            builder
                .HasOne(u => u.Venta)
                .WithMany(u => u.VentasPagos)
                .HasForeignKey(u => u.ID_VentaPago)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
