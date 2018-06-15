using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class itemdecomissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDecomissioned",
                table: "Item",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ItemDecomission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    DecomissionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDecomission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemDecomission_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDecomission_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemDecomission_ItemId",
                table: "ItemDecomission",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemDecomission_UserId",
                table: "ItemDecomission",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDecomission");

            migrationBuilder.DropColumn(
                name: "IsDecomissioned",
                table: "Item");
        }
    }
}
