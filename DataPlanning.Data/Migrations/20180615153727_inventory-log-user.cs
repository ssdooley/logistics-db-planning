using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class inventoryloguser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
