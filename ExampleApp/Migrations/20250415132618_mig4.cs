using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleApp.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Caris_CariId",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "CariId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CariId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CariId",
                table: "Orders",
                column: "CariId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Caris_CariId",
                table: "Orders",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Caris_CariId",
                table: "Products",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Caris_CariId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Caris_CariId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CariId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CariId",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "CariId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Caris_CariId",
                table: "Products",
                column: "CariId",
                principalTable: "Caris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
