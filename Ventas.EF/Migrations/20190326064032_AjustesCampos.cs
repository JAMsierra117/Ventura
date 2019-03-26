using Microsoft.EntityFrameworkCore.Migrations;

namespace Ventas.EF.Migrations
{
    public partial class AjustesCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostoUnitario",
                schema: "VentasDetalles",
                table: "VentasDetalles");

            migrationBuilder.RenameTable(
                name: "VentasPagos",
                schema: "VentasPagos",
                newName: "VentasPagos",
                newSchema: "Ventas");

            migrationBuilder.RenameTable(
                name: "VentasDetalles",
                schema: "VentasDetalles",
                newName: "VentasDetalles",
                newSchema: "Ventas");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Impuesto",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Importe",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "ID_Impuesto",
                schema: "Ventas",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Descuento",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Cantidad",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeDescuento",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeImpuesto",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnitario",
                schema: "Ventas",
                table: "VentasDetalles",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PorcentajeDescuento",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.DropColumn(
                name: "PorcentajeImpuesto",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.DropColumn(
                name: "PrecioUnitario",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.EnsureSchema(
                name: "VentasDetalles");

            migrationBuilder.EnsureSchema(
                name: "VentasPagos");

            migrationBuilder.RenameTable(
                name: "VentasPagos",
                schema: "Ventas",
                newName: "VentasPagos",
                newSchema: "VentasPagos");

            migrationBuilder.RenameTable(
                name: "VentasDetalles",
                schema: "Ventas",
                newName: "VentasDetalles",
                newSchema: "VentasDetalles");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Impuesto",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Importe",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ID_Impuesto",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Descuento",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cantidad",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AddColumn<decimal>(
                name: "CostoUnitario",
                schema: "VentasDetalles",
                table: "VentasDetalles",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
