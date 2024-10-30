using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colectivos",
                columns: table => new
                {
                    ColectivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadAsientos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colectivos", x => x.ColectivoId);
                });

            migrationBuilder.CreateTable(
                name: "Pasajeros",
                columns: table => new
                {
                    PasajeroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasajeros", x => x.PasajeroId);
                });

            migrationBuilder.CreateTable(
                name: "ColectivoPasajero",
                columns: table => new
                {
                    ColectivoId = table.Column<int>(type: "int", nullable: false),
                    PasajerosPasajeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColectivoPasajero", x => new { x.ColectivoId, x.PasajerosPasajeroId });
                    table.ForeignKey(
                        name: "FK_ColectivoPasajero_Colectivos_ColectivoId",
                        column: x => x.ColectivoId,
                        principalTable: "Colectivos",
                        principalColumn: "ColectivoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColectivoPasajero_Pasajeros_PasajerosPasajeroId",
                        column: x => x.PasajerosPasajeroId,
                        principalTable: "Pasajeros",
                        principalColumn: "PasajeroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColectivoPasajero_PasajerosPasajeroId",
                table: "ColectivoPasajero",
                column: "PasajerosPasajeroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColectivoPasajero");

            migrationBuilder.DropTable(
                name: "Colectivos");

            migrationBuilder.DropTable(
                name: "Pasajeros");
        }
    }
}
