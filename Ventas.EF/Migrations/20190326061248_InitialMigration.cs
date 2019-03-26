using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ventas.EF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ventas");

            migrationBuilder.EnsureSchema(
                name: "VentasDetalles");

            migrationBuilder.EnsureSchema(
                name: "VentasPagos");

            migrationBuilder.CreateTable(
                name: "Ventas",
                schema: "Ventas",
                columns: table => new
                {
                    ID_Venta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_UsuarioAlta = table.Column<int>(nullable: false),
                    RegistroAlta = table.Column<DateTime>(nullable: false),
                    ID_UsuarioCambio = table.Column<int>(nullable: false),
                    RegistroCambio = table.Column<DateTime>(nullable: false),
                    UUID = table.Column<Guid>(nullable: false),
                    ID_Cliente = table.Column<int>(nullable: false),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    Importe = table.Column<decimal>(nullable: false),
                    Descuento = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    Impuesto = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.ID_Venta);
                });

            migrationBuilder.CreateTable(
                name: "VentasDetalles",
                schema: "VentasDetalles",
                columns: table => new
                {
                    ID_VentaDetalle = table.Column<int>(nullable: false),
                    ID_UsuarioAlta = table.Column<int>(nullable: false),
                    RegistroAlta = table.Column<DateTime>(nullable: false),
                    ID_UsuarioCambio = table.Column<int>(nullable: false),
                    RegistroCambio = table.Column<DateTime>(nullable: false),
                    UUID = table.Column<Guid>(nullable: false),
                    ID_Venta = table.Column<int>(nullable: false),
                    CostoUnitario = table.Column<decimal>(nullable: false),
                    Cantidad = table.Column<decimal>(nullable: false),
                    Importe = table.Column<decimal>(nullable: false),
                    Descuento = table.Column<decimal>(nullable: false),
                    Impuesto = table.Column<decimal>(nullable: false),
                    ID_Impuesto = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDetalles", x => x.ID_VentaDetalle);
                    table.ForeignKey(
                        name: "FK_VentasDetalles_Ventas_ID_VentaDetalle",
                        column: x => x.ID_VentaDetalle,
                        principalSchema: "Ventas",
                        principalTable: "Ventas",
                        principalColumn: "ID_Venta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VentasPagos",
                schema: "VentasPagos",
                columns: table => new
                {
                    ID_VentaPago = table.Column<int>(nullable: false),
                    ID_UsuarioAlta = table.Column<int>(nullable: false),
                    RegistroAlta = table.Column<DateTime>(nullable: false),
                    ID_UsuarioCambio = table.Column<int>(nullable: false),
                    RegistroCambio = table.Column<DateTime>(nullable: false),
                    UUID = table.Column<Guid>(nullable: false),
                    ID_Venta = table.Column<int>(nullable: false),
                    ID_FormaPago = table.Column<int>(nullable: false),
                    Importe = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasPagos", x => x.ID_VentaPago);
                    table.ForeignKey(
                        name: "FK_VentasPagos_Ventas_ID_VentaPago",
                        column: x => x.ID_VentaPago,
                        principalSchema: "Ventas",
                        principalTable: "Ventas",
                        principalColumn: "ID_Venta",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentasDetalles",
                schema: "VentasDetalles");

            migrationBuilder.DropTable(
                name: "VentasPagos",
                schema: "VentasPagos");

            migrationBuilder.DropTable(
                name: "Ventas",
                schema: "Ventas");
        }
    }
}
