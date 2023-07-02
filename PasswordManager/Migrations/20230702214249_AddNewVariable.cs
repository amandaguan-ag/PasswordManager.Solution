using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManager.Migrations
{
    public partial class AddNewVariable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SiteEmail",
                table: "Passwords",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteEmail",
                table: "Passwords");
        }
    }
}
