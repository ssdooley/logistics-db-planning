using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class itemdecommissionverification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "ItemDecommission",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ItemDecommissionVerification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemDecommissionId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    VerificationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDecommissionVerification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemDecommissionVerification_ItemDecommission_ItemDecommissionId",
                        column: x => x.ItemDecommissionId,
                        principalTable: "ItemDecommission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDecommissionVerification_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDecommissionVerification_ItemDecommissionId",
                table: "ItemDecommissionVerification",
                column: "ItemDecommissionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDecommissionVerification_UserId",
                table: "ItemDecommissionVerification",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDecommissionVerification");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "ItemDecommission");
        }
    }
}
