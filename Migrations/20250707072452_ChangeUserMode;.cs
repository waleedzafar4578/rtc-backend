using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserMode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "[user]",
                newName: "status");

            migrationBuilder.AddColumn<string>(
                name: "bio",
                table: "[user]",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "[user]",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "[user]",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "[user]",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nickname",
                table: "[user]",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phoneno",
                table: "[user]",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "profilepicture",
                table: "[user]",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "removed",
                table: "[user]",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bio",
                table: "[user]");

            migrationBuilder.DropColumn(
                name: "email",
                table: "[user]");

            migrationBuilder.DropColumn(
                name: "firstname",
                table: "[user]");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "[user]");

            migrationBuilder.DropColumn(
                name: "nickname",
                table: "[user]");

            migrationBuilder.DropColumn(
                name: "phoneno",
                table: "[user]");

            migrationBuilder.DropColumn(
                name: "profilepicture",
                table: "[user]");

            migrationBuilder.DropColumn(
                name: "removed",
                table: "[user]");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "[user]",
                newName: "role");
        }
    }
}
