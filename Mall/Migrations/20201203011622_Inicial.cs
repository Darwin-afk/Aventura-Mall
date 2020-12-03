using Microsoft.EntityFrameworkCore.Migrations;

namespace Mall.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuentasBancarias",
                columns: table => new
                {
                    CuentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JugadorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Numeracion = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroTarjeta = table.Column<string>(type: "TEXT", nullable: true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Saldo = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasBancarias", x => x.CuentaId);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    JugadorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    Dinero = table.Column<decimal>(type: "TEXT", nullable: false),
                    Archivo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.JugadorId);
                });

            migrationBuilder.InsertData(
                table: "Jugadores",
                columns: new[] { "JugadorId", "Archivo", "Dinero", "Edad", "Nombres" },
                values: new object[] { 1, 0, 0m, 0, "" });

            migrationBuilder.InsertData(
                table: "Jugadores",
                columns: new[] { "JugadorId", "Archivo", "Dinero", "Edad", "Nombres" },
                values: new object[] { 2, 0, 0m, 0, "" });

            migrationBuilder.InsertData(
                table: "Jugadores",
                columns: new[] { "JugadorId", "Archivo", "Dinero", "Edad", "Nombres" },
                values: new object[] { 3, 0, 0m, 0, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentasBancarias");

            migrationBuilder.DropTable(
                name: "Jugadores");
        }
    }
}
