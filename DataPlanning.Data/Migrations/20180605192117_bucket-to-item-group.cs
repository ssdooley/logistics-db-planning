using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class buckettoitemgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Bucket_BucketId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Bucket");

            migrationBuilder.DropTable(
                name: "BucketCategory");

            migrationBuilder.CreateTable(
                name: "ItemGroupCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroupCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BucketCategoryId = table.Column<int>(nullable: false),
                    RequestId = table.Column<int>(nullable: false),
                    ItemGroupCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGroup_ItemGroupCategory_ItemGroupCategoryId",
                        column: x => x.ItemGroupCategoryId,
                        principalTable: "ItemGroupCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemGroup_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_ItemGroupCategoryId",
                table: "ItemGroup",
                column: "ItemGroupCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_RequestId",
                table: "ItemGroup",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemGroup_BucketId",
                table: "Item",
                column: "BucketId",
                principalTable: "ItemGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemGroup_BucketId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "ItemGroup");

            migrationBuilder.DropTable(
                name: "ItemGroupCategory");

            migrationBuilder.CreateTable(
                name: "BucketCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BucketCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bucket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BucketCategoryId = table.Column<int>(nullable: false),
                    RequestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bucket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bucket_BucketCategory_BucketCategoryId",
                        column: x => x.BucketCategoryId,
                        principalTable: "BucketCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bucket_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bucket_BucketCategoryId",
                table: "Bucket",
                column: "BucketCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bucket_RequestId",
                table: "Bucket",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Bucket_BucketId",
                table: "Item",
                column: "BucketId",
                principalTable: "Bucket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
