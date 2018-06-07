using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class onetoonerequeststatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_RequestStatus_RequestStatusId1",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_RequestStatusId1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RequestStatusId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RequestStatusId1",
                table: "Request");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStatus_RequestId",
                table: "RequestStatus",
                column: "RequestId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestStatus_Request_RequestId",
                table: "RequestStatus",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestStatus_Request_RequestId",
                table: "RequestStatus");

            migrationBuilder.DropIndex(
                name: "IX_RequestStatus_RequestId",
                table: "RequestStatus");

            migrationBuilder.AddColumn<int>(
                name: "RequestStatusId",
                table: "Request",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestStatusId1",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Request_RequestStatusId1",
                table: "Request",
                column: "RequestStatusId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_RequestStatus_RequestStatusId1",
                table: "Request",
                column: "RequestStatusId1",
                principalTable: "RequestStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
