using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TiendaAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Películas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Género = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duración = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Películas", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Películas",
                columns: new[] { "ID", "Director", "Duración", "Género", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Christopher Nolan", "2 horas 30 minutos", "Acción", "Data Seed1", 2.5 },
                    { 2, "Quentin Tarantino", "2 horas 15 minutos", "Comedia", "Data Seed2", 3.0 },
                    { 3, "Martin Scorsese", "2 horas 45 minutos", "Drama", "Data Seed3", 2.75 },
                    { 4, "James Cameron", "2 horas 20 minutos", "Ciencia Ficción", "Data Seed4", 2.8999999999999999 },
                    { 5, "Greta Gerwig", "2 horas", "Romance", "Data Seed5", 2.7999999999999998 },
                    { 6, "Alfred Hitchcock", "2 horas 10 minutos", "Suspense", "Data Seed6", 3.2000000000000002 },
                    { 7, "Tim Burton", "2 horas 5 minutos", "Fantasía", "Data Seed7", 2.6000000000000001 },
                    { 8, "Steven Spielberg", "2 horas 40 minutos", "Aventura", "Data Seed8", 3.1000000000000001 },
                    { 9, "David Fincher", "2 horas 25 minutos", "Misterio", "Data Seed9", 2.9500000000000002 },
                    { 10, "Hayao Miyazaki", "2 horas 50 minutos", "Animación", "Data Seed10", 3.0499999999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Películas");
        }
    }
}
