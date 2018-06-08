﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataPlanning.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FundingAccount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingAccount", x => x.Id);
                });

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
                name: "Priority",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
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
                name: "ApprovalTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalTemplate_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
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
                name: "FundUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    FundingAccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundUser_FundingAccount_FundingAccountId",
                        column: x => x.FundingAccountId,
                        principalTable: "FundingAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FundUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LogUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogUser_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LogUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriorityId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Requirement = table.Column<string>(nullable: true),
                    AuthorizedRegulation = table.Column<string>(nullable: true),
                    DateSubmitted = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    IsRecurring = table.Column<bool>(nullable: false),
                    RenewalDate = table.Column<DateTime>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_Priority_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "ApprovalTemplateGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApprovalGroupId = table.Column<int>(nullable: false),
                    ApprovalTemplateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalTemplateGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalTemplateGroup_ApprovalGroup_ApprovalGroupId",
                        column: x => x.ApprovalGroupId,
                        principalTable: "ApprovalGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApprovalTemplateGroup_ApprovalTemplate_ApprovalTemplateId",
                        column: x => x.ApprovalTemplateId,
                        principalTable: "ApprovalTemplate",
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
                name: "ItemGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FundingAccountId = table.Column<int>(nullable: false),
                    ItemGroupCategoryId = table.Column<int>(nullable: false),
                    RequestId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGroup_FundingAccount_FundingAccountId",
                        column: x => x.FundingAccountId,
                        principalTable: "FundingAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_ItemGroup_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
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
                    UserId = table.Column<int>(nullable: true),
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
                        name: "FK_ItemGroupApproval_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemGroupApproval_User_UserId",
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
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    File = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    AttachmentType = table.Column<string>(nullable: false),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    RequestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachment_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FundTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FundingAccountId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundTransaction_FundingAccount_FundingAccountId",
                        column: x => x.FundingAccountId,
                        principalTable: "FundingAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FundTransaction_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FundTransaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemCategoryId = table.Column<int>(nullable: false),
                    ManufacturerId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Nsn = table.Column<string>(nullable: true),
                    ItemType = table.Column<string>(nullable: false),
                    PropertyRecordId = table.Column<int>(nullable: true),
                    ServiceTag = table.Column<string>(nullable: true),
                    MacAddress = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    SerializedItem_PropertyRecordId = table.Column<int>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    SerializedItem_Location = table.Column<string>(nullable: true),
                    SoftwareItem_SiteId = table.Column<int>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    Users = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_PropertyRecord_PropertyRecordId",
                        column: x => x.PropertyRecordId,
                        principalTable: "PropertyRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_ItemCategory_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_PropertyRecord_SerializedItem_PropertyRecordId",
                        column: x => x.SerializedItem_PropertyRecordId,
                        principalTable: "PropertyRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Site_SoftwareItem_SiteId",
                        column: x => x.SoftwareItem_SiteId,
                        principalTable: "Site",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    ReceiptDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemReceipt_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemReceipt_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalTemplate_SiteId",
                table: "ApprovalTemplate",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalTemplateGroup_ApprovalGroupId",
                table: "ApprovalTemplateGroup",
                column: "ApprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalTemplateGroup_ApprovalTemplateId",
                table: "ApprovalTemplateGroup",
                column: "ApprovalTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Approver_ApprovalGroupId",
                table: "Approver",
                column: "ApprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Approver_UserId",
                table: "Approver",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_UserId",
                table: "Attachment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_OrderId",
                table: "Attachment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_RequestId",
                table: "Attachment",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_FundTransaction_FundingAccountId",
                table: "FundTransaction",
                column: "FundingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FundTransaction_OrderId",
                table: "FundTransaction",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_FundTransaction_UserId",
                table: "FundTransaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FundUser_FundingAccountId",
                table: "FundUser",
                column: "FundingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FundUser_UserId",
                table: "FundUser",
                column: "UserId");

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
                name: "IX_Item_OrderId",
                table: "Item",
                column: "OrderId");

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
                name: "IX_ItemGroup_FundingAccountId",
                table: "ItemGroup",
                column: "FundingAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_ItemGroupCategoryId",
                table: "ItemGroup",
                column: "ItemGroupCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_RequestId",
                table: "ItemGroup",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroup_SiteId",
                table: "ItemGroup",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroupApproval_ApprovalGroupId",
                table: "ItemGroupApproval",
                column: "ApprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroupApproval_ItemGroupId",
                table: "ItemGroupApproval",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroupApproval_UserId",
                table: "ItemGroupApproval",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReceipt_ItemId",
                table: "ItemReceipt",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReceipt_UserId",
                table: "ItemReceipt",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LogUser_SiteId",
                table: "LogUser",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_LogUser_UserId",
                table: "LogUser",
                column: "UserId");

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
                name: "IX_Request_PriorityId",
                table: "Request",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_SiteId",
                table: "Request",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                table: "Request",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestItem_ItemGroupId",
                table: "RequestItem",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestItem_RequestId",
                table: "RequestItem",
                column: "RequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalTemplateGroup");

            migrationBuilder.DropTable(
                name: "Approver");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "FundTransaction");

            migrationBuilder.DropTable(
                name: "FundUser");

            migrationBuilder.DropTable(
                name: "ItemGroupApproval");

            migrationBuilder.DropTable(
                name: "ItemReceipt");

            migrationBuilder.DropTable(
                name: "LogUser");

            migrationBuilder.DropTable(
                name: "PropertyCustodian");

            migrationBuilder.DropTable(
                name: "RequestItem");

            migrationBuilder.DropTable(
                name: "ApprovalTemplate");

            migrationBuilder.DropTable(
                name: "ApprovalGroup");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "PropertyRecord");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ItemCategory");

            migrationBuilder.DropTable(
                name: "ItemGroup");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "FundingAccount");

            migrationBuilder.DropTable(
                name: "ItemGroupCategory");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
