using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class propertytransfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyRecordId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DateStarted = table.Column<DateTime>(nullable: false),
                    DateCompleted = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_PropertyRecord_PropertyRecordId",
                        column: x => x.PropertyRecordId,
                        principalTable: "PropertyRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventory_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transfer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DestinationRecordId = table.Column<int>(nullable: false),
                    OriginRecordId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    IsReceived = table.Column<bool>(nullable: false),
                    TransferDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfer_PropertyRecord_DestinationRecordId",
                        column: x => x.DestinationRecordId,
                        principalTable: "PropertyRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transfer_PropertyRecord_OriginRecordId",
                        column: x => x.OriginRecordId,
                        principalTable: "PropertyRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transfer_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InventoryId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    IsAccounted = table.Column<bool>(nullable: false),
                    IsMissing = table.Column<bool>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItem_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransferItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    TransferId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferItem_Transfer_TransferId",
                        column: x => x.TransferId,
                        principalTable: "Transfer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransferReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TransferId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    ReceiptDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferReceipt_Transfer_TransferId",
                        column: x => x.TransferId,
                        principalTable: "Transfer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferReceipt_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_PropertyRecordId",
                table: "Inventory",
                column: "PropertyRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UserId",
                table: "Inventory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_InventoryId",
                table: "InventoryItem",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_ItemId",
                table: "InventoryItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_DestinationRecordId",
                table: "Transfer",
                column: "DestinationRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_OriginRecordId",
                table: "Transfer",
                column: "OriginRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfer_UserId",
                table: "Transfer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferItem_ItemId",
                table: "TransferItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferItem_TransferId",
                table: "TransferItem",
                column: "TransferId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferReceipt_TransferId",
                table: "TransferReceipt",
                column: "TransferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransferReceipt_UserId",
                table: "TransferReceipt",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItem");

            migrationBuilder.DropTable(
                name: "TransferItem");

            migrationBuilder.DropTable(
                name: "TransferReceipt");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Transfer");
        }
    }
}
