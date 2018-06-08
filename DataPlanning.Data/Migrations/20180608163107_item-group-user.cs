using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class itemgroupuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ItemGroup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_UserId",
                table: "ItemGroup",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroup_User_UserId",
                table: "ItemGroup",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroup_User_UserId",
                table: "ItemGroup");

            migrationBuilder.DropIndex(
                name: "IX_ItemGroup_UserId",
                table: "ItemGroup");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ItemGroup");
        }
    }
}
