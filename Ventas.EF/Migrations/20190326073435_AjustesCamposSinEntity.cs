using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ventas.EF.Migrations
{
    public partial class AjustesCamposSinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_UsuarioAlta",
                schema: "Ventas",
                table: "VentasPagos");

            migrationBuilder.DropColumn(
                name: "ID_UsuarioCambio",
                schema: "Ventas",
                table: "VentasPagos");

            migrationBuilder.DropColumn(
                name: "RegistroAlta",
                schema: "Ventas",
                table: "VentasPagos");

            migrationBuilder.DropColumn(
                name: "RegistroCambio",
                schema: "Ventas",
                table: "VentasPagos");

            migrationBuilder.DropColumn(
                name: "UUID",
                schema: "Ventas",
                table: "VentasPagos");

            migrationBuilder.DropColumn(
                name: "ID_UsuarioAlta",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.DropColumn(
                name: "ID_UsuarioCambio",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.DropColumn(
                name: "RegistroAlta",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.DropColumn(
                name: "RegistroCambio",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.DropColumn(
                name: "UUID",
                schema: "Ventas",
                table: "VentasDetalles");

            migrationBuilder.DropColumn(
                name: "ID_UsuarioAlta",
                schema: "Ventas",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ID_UsuarioCambio",
                schema: "Ventas",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "RegistroAlta",
                schema: "Ventas",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "RegistroCambio",
                schema: "Ventas",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "UUID",
                schema: "Ventas",
                table: "Ventas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_UsuarioAlta",
                schema: "Ventas",
                table: "VentasPagos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_UsuarioCambio",
                schema: "Ventas",
                table: "VentasPagos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistroAlta",
                schema: "Ventas",
                table: "VentasPagos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistroCambio",
                schema: "Ventas",
                table: "VentasPagos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UUID",
                schema: "Ventas",
                table: "VentasPagos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "ID_UsuarioAlta",
                schema: "Ventas",
                table: "VentasDetalles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_UsuarioCambio",
                schema: "Ventas",
                table: "VentasDetalles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistroAlta",
                schema: "Ventas",
                table: "VentasDetalles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistroCambio",
                schema: "Ventas",
                table: "VentasDetalles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UUID",
                schema: "Ventas",
                table: "VentasDetalles",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "ID_UsuarioAlta",
                schema: "Ventas",
                table: "Ventas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_UsuarioCambio",
                schema: "Ventas",
                table: "Ventas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistroAlta",
                schema: "Ventas",
                table: "Ventas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistroCambio",
                schema: "Ventas",
                table: "Ventas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UUID",
                schema: "Ventas",
                table: "Ventas",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
