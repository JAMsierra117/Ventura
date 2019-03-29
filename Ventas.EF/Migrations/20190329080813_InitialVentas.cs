using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ventas.EF.Migrations
{
    public partial class InitialVentas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ventas");

            migrationBuilder.CreateTable(
                name: "Ventas",
                schema: "Ventas",
                columns: table => new
                {
                    ID_Venta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Cliente = table.Column<int>(nullable: false),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    Importe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Impuesto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.ID_Venta);
                });

            migrationBuilder.CreateTable(
                name: "VentasDetalles",
                schema: "Ventas",
                columns: table => new
                {
                    ID_VentaDetalle = table.Column<int>(nullable: false),
                    ID_Venta = table.Column<int>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Importe = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PorcentajeDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Impuesto = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PorcentajeImpuesto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ID_Impuesto = table.Column<int>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
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
                schema: "Ventas",
                columns: table => new
                {
                    ID_VentaPago = table.Column<int>(nullable: false),
                    ID_Venta = table.Column<int>(nullable: false),
                    ID_FormaPago = table.Column<int>(nullable: false),
                    Importe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                schema: "Ventas");

            migrationBuilder.DropTable(
                name: "VentasPagos",
                schema: "Ventas");

            migrationBuilder.DropTable(
                name: "Ventas",
                schema: "Ventas");
        }
    }
}
