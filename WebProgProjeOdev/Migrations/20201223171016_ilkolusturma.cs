using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgProjeOdev.Migrations
{
    public partial class ilkolusturma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalogMakines",
                columns: table => new
                {
                    AnalogMakineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakineAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalogMakines", x => x.AnalogMakineID);
                });

            migrationBuilder.CreateTable(
                name: "AnalogFotografs",
                columns: table => new
                {
                    AnalogFotografID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotografAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotografKonum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    analogMakineID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalogFotografs", x => x.AnalogFotografID);
                    table.ForeignKey(
                        name: "FK_AnalogFotografs_AnalogMakines_analogMakineID",
                        column: x => x.analogMakineID,
                        principalTable: "AnalogMakines",
                        principalColumn: "AnalogMakineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalogFotografs_analogMakineID",
                table: "AnalogFotografs",
                column: "analogMakineID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalogFotografs");

            migrationBuilder.DropTable(
                name: "AnalogMakines");
        }
    }
}
