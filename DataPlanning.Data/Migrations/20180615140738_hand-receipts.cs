using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class handreceipts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HandReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HandReceipt_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HandReceipt_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HandReceiptItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HandReceiptId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    NsnItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandReceiptItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HandReceiptItem_HandReceipt_HandReceiptId",
                        column: x => x.HandReceiptId,
                        principalTable: "HandReceipt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HandReceiptItem_Item_NsnItemId",
                        column: x => x.NsnItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HandReceiptVerification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HandReceiptId = table.Column<int>(nullable: false),
                    LogUserId = table.Column<int>(nullable: false),
                    RecordUserId = table.Column<int>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: false),
                    DateVerified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandReceiptVerification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HandReceiptVerification_HandReceipt_HandReceiptId",
                        column: x => x.HandReceiptId,
                        principalTable: "HandReceipt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HandReceiptVerification_User_LogUserId",
                        column: x => x.LogUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HandReceiptVerification_User_RecordUserId",
                        column: x => x.RecordUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HandReceipt_SiteId",
                table: "HandReceipt",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_HandReceipt_UserId",
                table: "HandReceipt",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HandReceiptItem_HandReceiptId",
                table: "HandReceiptItem",
                column: "HandReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_HandReceiptItem_NsnItemId",
                table: "HandReceiptItem",
                column: "NsnItemId");

            migrationBuilder.CreateIndex(
                name: "IX_HandReceiptVerification_HandReceiptId",
                table: "HandReceiptVerification",
                column: "HandReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_HandReceiptVerification_LogUserId",
                table: "HandReceiptVerification",
                column: "LogUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HandReceiptVerification_RecordUserId",
                table: "HandReceiptVerification",
                column: "RecordUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HandReceiptItem");

            migrationBuilder.DropTable(
                name: "HandReceiptVerification");

            migrationBuilder.DropTable(
                name: "HandReceipt");
        }
    }
}
