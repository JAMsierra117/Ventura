﻿// <auto-generated />
using Generales.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Generales.EF.Migrations
{
    [DbContext(typeof(GeneralesContext))]
    [Migration("20190326031153_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Generales.Core.Models.Clasificacion", b =>
                {
                    b.Property<int>("ID_Clasificacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.HasKey("ID_Clasificacion");

                    b.ToTable("Clasificaciones","Generales");
                });

            modelBuilder.Entity("Generales.Core.Models.Producto", b =>
                {
                    b.Property<int>("ID_Producto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoProducto");

                    b.Property<int>("ID_Clasificacion");

                    b.Property<string>("NombreProducto");

                    b.HasKey("ID_Producto");

                    b.HasIndex("ID_Clasificacion");

                    b.ToTable("Productos","Generales");
                });

            modelBuilder.Entity("Generales.Core.Models.Producto", b =>
                {
                    b.HasOne("Generales.Core.Models.Clasificacion", "Clasificacion")
                        .WithMany("Productos")
                        .HasForeignKey("ID_Clasificacion")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
