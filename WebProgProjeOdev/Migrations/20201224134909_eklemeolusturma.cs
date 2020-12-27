using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgProjeOdev.Migrations
{
    public partial class eklemeolusturma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detay",
                table: "AnalogMakines",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detay",
                table: "AnalogMakines");
        }
    }
}
