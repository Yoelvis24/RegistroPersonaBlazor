using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroBlazor.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: true),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    Balance = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamoId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrestamoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PrestamosId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                    table.ForeignKey(
                        name: "FK_Personas_Prestamos_PrestamosId",
                        column: x => x.PrestamosId,
                        principalTable: "Prestamos",
                        principalColumn: "PrestamoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_PrestamosId",
                table: "Personas",
                column: "PrestamosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Prestamos");
        }
    }
}
