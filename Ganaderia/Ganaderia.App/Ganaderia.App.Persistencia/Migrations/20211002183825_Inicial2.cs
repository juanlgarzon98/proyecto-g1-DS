using Microsoft.EntityFrameworkCore.Migrations;

namespace Ganaderia.App.Persistencia.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Especialidad",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TargetaProfesional",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Veterinario_Latitud",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Veterinario_Longitud",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ejemplares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Finca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacunas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVencimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laboratorio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacunas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ejemplares");

            migrationBuilder.DropTable(
                name: "Finca");

            migrationBuilder.DropTable(
                name: "HistoriaClinica");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "Vacunas");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TargetaProfesional",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Veterinario_Latitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Veterinario_Longitud",
                table: "Personas");
        }
    }
}
