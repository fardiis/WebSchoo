using Microsoft.EntityFrameworkCore.Migrations;

namespace Schooldemo.Migrations
{
    public partial class webdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true);
        }
    }
}
