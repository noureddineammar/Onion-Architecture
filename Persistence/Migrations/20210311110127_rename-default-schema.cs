using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class renamedefaultschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SuperSub");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Identity",
                newName: "UserTokens",
                newSchema: "SuperSub");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Identity",
                newName: "Users",
                newSchema: "SuperSub");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Identity",
                newName: "UserRoles",
                newSchema: "SuperSub");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Identity",
                newName: "UserLogins",
                newSchema: "SuperSub");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Identity",
                newName: "UserClaims",
                newSchema: "SuperSub");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "Identity",
                newName: "Roles",
                newSchema: "SuperSub");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Identity",
                newName: "RoleClaims",
                newSchema: "SuperSub");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Identity",
                newName: "Products",
                newSchema: "SuperSub");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "SuperSub",
                newName: "UserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "SuperSub",
                newName: "Users",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "SuperSub",
                newName: "UserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "SuperSub",
                newName: "UserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "SuperSub",
                newName: "UserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "SuperSub",
                newName: "Roles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "SuperSub",
                newName: "RoleClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "SuperSub",
                newName: "Products",
                newSchema: "Identity");
        }
    }
}
