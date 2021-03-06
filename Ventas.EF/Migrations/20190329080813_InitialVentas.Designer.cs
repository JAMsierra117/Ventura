﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ventas.EF.Context;

namespace Ventas.EF.Migrations
{
    [DbContext(typeof(VentasContext))]
    [Migration("20190329080813_InitialVentas")]
    partial class InitialVentas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Ventas")
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ventas.Core.Models.Venta", b =>
                {
                    b.Property<int>("ID_Venta")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FechaVenta");

                    b.Property<int>("ID_Cliente");

                    b.Property<decimal>("Importe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Impuesto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_Venta");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Ventas.Core.Models.VentaDetalle", b =>
                {
                    b.Property<int>("ID_VentaDetalle");

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("ID_Impuesto");

                    b.Property<int>("ID_Venta");

                    b.Property<decimal>("Importe")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("Impuesto")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("PorcentajeDescuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeImpuesto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,6)");

                    b.HasKey("ID_VentaDetalle");

                    b.ToTable("VentasDetalles");
                });

            modelBuilder.Entity("Ventas.Core.Models.VentaPago", b =>
                {
                    b.Property<int>("ID_VentaPago");

                    b.Property<int>("ID_FormaPago");

                    b.Property<int>("ID_Venta");

                    b.Property<decimal>("Importe")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_VentaPago");

                    b.ToTable("VentasPagos");
                });

            modelBuilder.Entity("Ventas.Core.Models.VentaDetalle", b =>
                {
                    b.HasOne("Ventas.Core.Models.Venta", "Venta")
                        .WithMany("VentaDetalles")
                        .HasForeignKey("ID_VentaDetalle")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Ventas.Core.Models.VentaPago", b =>
                {
                    b.HasOne("Ventas.Core.Models.Venta", "Venta")
                        .WithMany("VentasPagos")
                        .HasForeignKey("ID_VentaPago")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
