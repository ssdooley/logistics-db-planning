using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class inventoryverification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_User_LogUserId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_LogUserId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "LogUserId",
                table: "Inventory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCompleted",
                table: "Inventory",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateTable(
                name: "InventoryVerification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InventoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryVerification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryVerification_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryVerification_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVerification_InventoryId",
                table: "InventoryVerification",
                column: "InventoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVerification_UserId",
                table: "InventoryVerification",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryVerification");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCompleted",
                table: "Inventory",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LogUserId",
                table: "Inventory",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_LogUserId",
                table: "Inventory",
                column: "LogUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_User_LogUserId",
                table: "Inventory",
                column: "LogUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
