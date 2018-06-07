using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class approvalsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemGroupStatus");

            migrationBuilder.CreateTable(
                name: "ApprovalGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true),
                    IsLocal = table.Column<bool>(nullable: false),
                    IsCommander = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Approver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApprovalGroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Approver_ApprovalGroup_ApprovalGroupId",
                        column: x => x.ApprovalGroupId,
                        principalTable: "ApprovalGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Approver_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroupApproval",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemGroupId = table.Column<int>(nullable: false),
                    ApprovalGroupId = table.Column<int>(nullable: false),
                    ApproverId = table.Column<int>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsRejected = table.Column<bool>(nullable: false),
                    IsPostponed = table.Column<bool>(nullable: false),
                    PostponedUntil = table.Column<DateTime>(nullable: true),
                    DateApproved = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroupApproval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGroupApproval_ApprovalGroup_ApprovalGroupId",
                        column: x => x.ApprovalGroupId,
                        principalTable: "ApprovalGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemGroupApproval_Approver_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "Approver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemGroupApproval_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Approver_ApprovalGroupId",
                table: "Approver",
                column: "ApprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Approver_UserId",
                table: "Approver",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroupApproval_ApprovalGroupId",
                table: "ItemGroupApproval",
                column: "ApprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroupApproval_ApproverId",
                table: "ItemGroupApproval",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroupApproval_ItemGroupId",
                table: "ItemGroupApproval",
                column: "ItemGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemGroupApproval");

            migrationBuilder.DropTable(
                name: "Approver");

            migrationBuilder.DropTable(
                name: "ApprovalGroup");

            migrationBuilder.CreateTable(
                name: "ItemGroupStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsPostponed = table.Column<bool>(nullable: false),
                    IsRejected = table.Column<bool>(nullable: false),
                    ItemGroupId = table.Column<int>(nullable: false),
                    PostponedUntil = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroupStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGroupStatus_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroupStatus_ItemGroupId",
                table: "ItemGroupStatus",
                column: "ItemGroupId",
                unique: true);
        }
    }
}
