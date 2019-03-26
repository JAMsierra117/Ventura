using Generales.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generales.EF.Configurations
{
    public class ProductosConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder
                .ToTable("Productos", "Generales")
                .HasKey(k => k.ID_Producto);

            builder
                .HasOne(u => u.Clasificacion)
                .WithMany(u => u.Productos)
                .HasForeignKey(u => u.ID_Clasificacion)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
