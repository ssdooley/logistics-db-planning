using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class requeststatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRecurring",
                table: "Request",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RenewalDate",
                table: "Request",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestStatusId",
                table: "Request",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestStatusId1",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RequestStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestId = table.Column<int>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsRejected = table.Column<bool>(nullable: false),
                    IsPostponed = table.Column<bool>(nullable: false),
                    PostponedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatus", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_RequestStatus_RequestStatusId1",
                table: "Request");

            migrationBuilder.DropTable(
                name: "RequestStatus");

            migrationBuilder.DropIndex(
                name: "IX_Request_RequestStatusId1",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "IsRecurring",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RenewalDate",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RequestStatusId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RequestStatusId1",
                table: "Request");
        }
    }
}
