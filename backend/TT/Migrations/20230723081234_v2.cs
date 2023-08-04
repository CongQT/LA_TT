using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TT.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nguoiXuLy",
                table: "dondangkis",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nguoiXuLy",
                table: "dondangkis");
        }
    }
}
