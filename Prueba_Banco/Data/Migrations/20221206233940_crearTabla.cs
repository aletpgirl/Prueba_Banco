using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_Banco.Data.Migrations
{
    public partial class crearTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODGTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMGTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODCOOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMCOOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODVENTAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMVEND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODNIVEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMNIVEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIT_CLIENTE = table.Column<float>(type: "real", nullable: true),
                    ITEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_CLIENTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEGMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GERENCIADO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OFICINA_CLIENTE = table.Column<float>(type: "real", nullable: true),
                    FECHAFIL = table.Column<float>(type: "real", nullable: true),
                    PERIODOMED = table.Column<int>(type: "int", nullable: true),
                    CONDIC = table.Column<int>(type: "int", nullable: true),
                    CTACAMP = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
