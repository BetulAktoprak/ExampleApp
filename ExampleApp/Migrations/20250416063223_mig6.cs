using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleApp.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Caris");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Caris");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AppUsers",
                newName: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AppUsers",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Caris",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
