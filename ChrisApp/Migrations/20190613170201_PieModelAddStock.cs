using Microsoft.EntityFrameworkCore.Migrations;

namespace ChrisApp.Migrations
{
    public partial class PieModelAddStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Slimes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Slimes");
        }
    }
}
