using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManager.Migrations
{
    public partial class VariableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Passwords",
                newName: "SiteUsername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SiteUsername",
                table: "Passwords",
                newName: "Username");
        }
    }
}
