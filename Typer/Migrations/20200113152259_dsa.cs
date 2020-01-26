using Microsoft.EntityFrameworkCore.Migrations;

namespace Typer.Migrations
{
    public partial class dsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ASd",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ASd",
                table: "Users");
        }
    }
}
