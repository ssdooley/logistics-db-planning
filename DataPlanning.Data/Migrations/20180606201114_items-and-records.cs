using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class itemsandrecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemGroup_BucketId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Request_RequestId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroupApproval_Approver_ApproverId",
                table: "ItemGroupApproval");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_User_RequestorId",
                table: "Request");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropIndex(
                name: "IX_Item_BucketId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "BucketCategoryId",
                table: "ItemGroup");

            migrationBuilder.DropColumn(
                name: "BucketId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "RequestorId",
                table: "Request",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Request_RequestorId",
                table: "Request",
                newName: "IX_Request_UserId");

            migrationBuilder.RenameColumn(
                name: "ApproverId",
                table: "ItemGroupApproval",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemGroupApproval_ApproverId",
                table: "ItemGroupApproval",
                newName: "IX_ItemGroupApproval_UserId");

            migrationBuilder.RenameColumn(
                name: "RequestId",
                table: "Item",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Item",
                newName: "Nsn");

            migrationBuilder.RenameIndex(
                name: "IX_Item_RequestId",
                table: "Item",
                newName: "IX_Item_OrderId");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Request",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "Request",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "ItemGroupCategoryId",
                table: "ItemGroup",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Item",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MacAddress",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyRecordId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceTag",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCategoryId",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ItemType",
                table: "Item",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerializedItem_Location",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerializedItem_PropertyRecordId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerializedItem_SerialNumber",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "License",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoftwareItem_SiteId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Users",
                table: "Item",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemGroupCategoryId = table.Column<int>(nullable: false),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCategory_ItemGroupCategory_ItemGroupCategoryId",
                        column: x => x.ItemGroupCategoryId,
                        principalTable: "ItemGroupCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyRecord_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestId = table.Column<int>(nullable: false),
                    File = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    DateUploaded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestAttachment_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemGroupId = table.Column<int>(nullable: true),
                    RequestId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestItem_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequestItem_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturer_ItemCategory_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCustodian",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyRecordId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCustodian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyCustodian_PropertyRecord_PropertyRecordId",
                        column: x => x.PropertyRecordId,
                        principalTable: "PropertyRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertyCustodian_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemGroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    TrackingNumber = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    IsReceived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    File = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    DateUploaded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAttachment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_PropertyRecordId",
                table: "Item",
                column: "PropertyRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemCategoryId",
                table: "Item",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ManufacturerId",
                table: "Item",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SiteId",
                table: "Item",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SerializedItem_PropertyRecordId",
                table: "Item",
                column: "SerializedItem_PropertyRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SoftwareItem_SiteId",
                table: "Item",
                column: "SoftwareItem_SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_ItemGroupCategoryId",
                table: "ItemCategory",
                column: "ItemGroupCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturer_ItemCategoryId",
                table: "Manufacturer",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ItemGroupId",
                table: "Order",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_VendorId",
                table: "Order",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAttachment_OrderId",
                table: "OrderAttachment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCustodian_PropertyRecordId",
                table: "PropertyCustodian",
                column: "PropertyRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyCustodian_UserId",
                table: "PropertyCustodian",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRecord_SiteId",
                table: "PropertyRecord",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestAttachment_RequestId",
                table: "RequestAttachment",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestItem_ItemGroupId",
                table: "RequestItem",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestItem_RequestId",
                table: "RequestItem",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_PropertyRecord_PropertyRecordId",
                table: "Item",
                column: "PropertyRecordId",
                principalTable: "PropertyRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemCategory_ItemCategoryId",
                table: "Item",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Manufacturer_ManufacturerId",
                table: "Item",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Order_OrderId",
                table: "Item",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Site_SiteId",
                table: "Item",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_PropertyRecord_SerializedItem_PropertyRecordId",
                table: "Item",
                column: "SerializedItem_PropertyRecordId",
                principalTable: "PropertyRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Site_SoftwareItem_SiteId",
                table: "Item",
                column: "SoftwareItem_SiteId",
                principalTable: "Site",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroupApproval_User_UserId",
                table: "ItemGroupApproval",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_User_UserId",
                table: "Request",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_PropertyRecord_PropertyRecordId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemCategory_ItemCategoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Manufacturer_ManufacturerId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Order_OrderId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Site_SiteId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_PropertyRecord_SerializedItem_PropertyRecordId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Site_SoftwareItem_SiteId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemGroupApproval_User_UserId",
                table: "ItemGroupApproval");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_User_UserId",
                table: "Request");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "OrderAttachment");

            migrationBuilder.DropTable(
                name: "PropertyCustodian");

            migrationBuilder.DropTable(
                name: "RequestAttachment");

            migrationBuilder.DropTable(
                name: "RequestItem");

            migrationBuilder.DropTable(
                name: "ItemCategory");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PropertyRecord");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_Item_PropertyRecordId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ItemCategoryId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ManufacturerId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_SiteId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_SerializedItem_PropertyRecordId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_SoftwareItem_SiteId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "MacAddress",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PropertyRecordId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ServiceTag",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SerializedItem_Location",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SerializedItem_PropertyRecordId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SerializedItem_SerialNumber",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "License",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SoftwareItem_SiteId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Users",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Request",
                newName: "RequestorId");

            migrationBuilder.RenameIndex(
                name: "IX_Request_UserId",
                table: "Request",
                newName: "IX_Request_RequestorId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ItemGroupApproval",
                newName: "ApproverId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemGroupApproval_UserId",
                table: "ItemGroupApproval",
                newName: "IX_ItemGroupApproval_ApproverId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Item",
                newName: "RequestId");

            migrationBuilder.RenameColumn(
                name: "Nsn",
                table: "Item",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Item_OrderId",
                table: "Item",
                newName: "IX_Item_RequestId");

            migrationBuilder.AlterColumn<int>(
                name: "ItemGroupCategoryId",
                table: "ItemGroup",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BucketCategoryId",
                table: "ItemGroup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Item",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BucketId",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Item",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    File = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    RequestId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_BucketId",
                table: "Item",
                column: "BucketId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_RequestId",
                table: "Attachment",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemGroup_BucketId",
                table: "Item",
                column: "BucketId",
                principalTable: "ItemGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Request_RequestId",
                table: "Item",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemGroupApproval_Approver_ApproverId",
                table: "ItemGroupApproval",
                column: "ApproverId",
                principalTable: "Approver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_User_RequestorId",
                table: "Request",
                column: "RequestorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
