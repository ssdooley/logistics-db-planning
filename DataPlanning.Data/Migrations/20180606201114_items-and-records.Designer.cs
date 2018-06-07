﻿// <auto-generated />
using System;
using DataPlanning.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataPlanning.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180606201114_items-and-records")]
    partial class itemsandrecords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataPlanning.Data.ApprovalGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsCommander");

                    b.Property<bool>("IsLocal");

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("ApprovalGroup");
                });

            modelBuilder.Entity("DataPlanning.Data.Approver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovalGroupId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ApprovalGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Approver");
                });

            modelBuilder.Entity("DataPlanning.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemCategoryId");

                    b.Property<string>("ItemType")
                        .IsRequired();

                    b.Property<int>("ManufacturerId");

                    b.Property<string>("Model");

                    b.Property<string>("Nsn");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("ItemCategoryId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("ItemType").HasValue("Base");
                });

            modelBuilder.Entity("DataPlanning.Data.ItemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemGroupCategoryId");

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.HasIndex("ItemGroupCategoryId");

                    b.ToTable("ItemCategory");
                });

            modelBuilder.Entity("DataPlanning.Data.ItemGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemGroupCategoryId");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("ItemGroupCategoryId");

                    b.HasIndex("RequestId");

                    b.ToTable("ItemGroup");
                });

            modelBuilder.Entity("DataPlanning.Data.ItemGroupApproval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovalGroupId");

                    b.Property<DateTime?>("DateApproved");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsPostponed");

                    b.Property<bool>("IsRejected");

                    b.Property<int>("ItemGroupId");

                    b.Property<DateTime?>("PostponedUntil");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ApprovalGroupId");

                    b.HasIndex("ItemGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("ItemGroupApproval");
                });

            modelBuilder.Entity("DataPlanning.Data.ItemGroupCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("ItemGroupCategory");
                });

            modelBuilder.Entity("DataPlanning.Data.LogUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SiteId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("LogUser");
                });

            modelBuilder.Entity("DataPlanning.Data.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemCategoryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ItemCategoryId");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("DataPlanning.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost");

                    b.Property<bool>("IsReceived");

                    b.Property<int>("ItemGroupId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("Remarks");

                    b.Property<string>("TrackingNumber");

                    b.Property<int>("UserId");

                    b.Property<int>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("ItemGroupId");

                    b.HasIndex("UserId");

                    b.HasIndex("VendorId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DataPlanning.Data.OrderAttachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUploaded");

                    b.Property<string>("File");

                    b.Property<int>("OrderId");

                    b.Property<string>("Path");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderAttachment");
                });

            modelBuilder.Entity("DataPlanning.Data.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("Priority");
                });

            modelBuilder.Entity("DataPlanning.Data.PropertyCustodian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PropertyRecordId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyRecordId");

                    b.HasIndex("UserId");

                    b.ToTable("PropertyCustodian");
                });

            modelBuilder.Entity("DataPlanning.Data.PropertyRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("SiteId");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("PropertyRecord");
                });

            modelBuilder.Entity("DataPlanning.Data.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorizedRegulation");

                    b.Property<DateTime>("DateSubmitted");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsComplete");

                    b.Property<bool>("IsRecurring");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("PriorityId");

                    b.Property<DateTime?>("RenewalDate");

                    b.Property<string>("Requirement");

                    b.Property<int>("SiteId");

                    b.Property<string>("Subject");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PriorityId");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("DataPlanning.Data.RequestAttachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUploaded");

                    b.Property<string>("File");

                    b.Property<string>("Path");

                    b.Property<int>("RequestId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestAttachment");
                });

            modelBuilder.Entity("DataPlanning.Data.RequestItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost");

                    b.Property<int?>("ItemGroupId");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("ItemGroupId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestItem");
                });

            modelBuilder.Entity("DataPlanning.Data.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("DataPlanning.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DataPlanning.Data.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("DataPlanning.Data.HardwareItem", b =>
                {
                    b.HasBaseType("DataPlanning.Data.Item");

                    b.Property<string>("Location");

                    b.Property<string>("MacAddress");

                    b.Property<int>("PropertyRecordId");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("ServiceTag");

                    b.HasIndex("PropertyRecordId");

                    b.ToTable("HardwareItem");

                    b.HasDiscriminator().HasValue("Hardware");
                });

            modelBuilder.Entity("DataPlanning.Data.NsnItem", b =>
                {
                    b.HasBaseType("DataPlanning.Data.Item");

                    b.Property<int>("Quantity");

                    b.Property<int>("SiteId");

                    b.HasIndex("SiteId");

                    b.ToTable("NsnItem");

                    b.HasDiscriminator().HasValue("NonSerialized");
                });

            modelBuilder.Entity("DataPlanning.Data.SerializedItem", b =>
                {
                    b.HasBaseType("DataPlanning.Data.Item");

                    b.Property<string>("Location")
                        .HasColumnName("SerializedItem_Location");

                    b.Property<int>("PropertyRecordId")
                        .HasColumnName("SerializedItem_PropertyRecordId");

                    b.Property<string>("SerialNumber")
                        .HasColumnName("SerializedItem_SerialNumber");

                    b.HasIndex("PropertyRecordId");

                    b.ToTable("SerializedItem");

                    b.HasDiscriminator().HasValue("Serialized");
                });

            modelBuilder.Entity("DataPlanning.Data.SoftwareItem", b =>
                {
                    b.HasBaseType("DataPlanning.Data.Item");

                    b.Property<string>("License");

                    b.Property<int>("SiteId")
                        .HasColumnName("SoftwareItem_SiteId");

                    b.Property<int>("Users");

                    b.HasIndex("SiteId");

                    b.ToTable("SoftwareItem");

                    b.HasDiscriminator().HasValue("Software");
                });

            modelBuilder.Entity("DataPlanning.Data.Approver", b =>
                {
                    b.HasOne("DataPlanning.Data.ApprovalGroup", "ApprovalGroup")
                        .WithMany("Approvers")
                        .HasForeignKey("ApprovalGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User", "User")
                        .WithMany("Approvers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.Item", b =>
                {
                    b.HasOne("DataPlanning.Data.ItemCategory", "ItemCategory")
                        .WithMany("Items")
                        .HasForeignKey("ItemCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Manufacturer", "Manufacturer")
                        .WithMany("Items")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.ItemCategory", b =>
                {
                    b.HasOne("DataPlanning.Data.ItemGroupCategory", "ItemGroupCategory")
                        .WithMany("ItemCategories")
                        .HasForeignKey("ItemGroupCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.ItemGroup", b =>
                {
                    b.HasOne("DataPlanning.Data.ItemGroupCategory", "ItemGroupCategory")
                        .WithMany("ItemGroups")
                        .HasForeignKey("ItemGroupCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Request", "Request")
                        .WithMany("ItemGroups")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.ItemGroupApproval", b =>
                {
                    b.HasOne("DataPlanning.Data.ApprovalGroup", "ApprovalGroup")
                        .WithMany("ItemGroupApprovals")
                        .HasForeignKey("ApprovalGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.ItemGroup", "ItemGroup")
                        .WithMany("ItemGroupApprovals")
                        .HasForeignKey("ItemGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User", "User")
                        .WithMany("ItemGroupApprovals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.LogUser", b =>
                {
                    b.HasOne("DataPlanning.Data.Site", "Site")
                        .WithMany("LogUsers")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User", "User")
                        .WithMany("LogUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.Manufacturer", b =>
                {
                    b.HasOne("DataPlanning.Data.ItemCategory", "ItemCategory")
                        .WithMany("Manufacturers")
                        .HasForeignKey("ItemCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.Order", b =>
                {
                    b.HasOne("DataPlanning.Data.ItemGroup", "ItemGroup")
                        .WithMany("Orders")
                        .HasForeignKey("ItemGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Vendor", "Vendor")
                        .WithMany("Orders")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.OrderAttachment", b =>
                {
                    b.HasOne("DataPlanning.Data.Order", "Order")
                        .WithMany("OrderAttachments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.PropertyCustodian", b =>
                {
                    b.HasOne("DataPlanning.Data.PropertyRecord", "PropertyRecord")
                        .WithMany("PropertyCustodians")
                        .HasForeignKey("PropertyRecordId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User", "User")
                        .WithMany("PropertyCustodians")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.PropertyRecord", b =>
                {
                    b.HasOne("DataPlanning.Data.Site", "Site")
                        .WithMany("PropertyRecords")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.Request", b =>
                {
                    b.HasOne("DataPlanning.Data.Priority", "Priority")
                        .WithMany("Requests")
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Site", "Site")
                        .WithMany("Requests")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.RequestAttachment", b =>
                {
                    b.HasOne("DataPlanning.Data.Request", "Request")
                        .WithMany("RequestAttachments")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.RequestItem", b =>
                {
                    b.HasOne("DataPlanning.Data.ItemGroup", "ItemGroup")
                        .WithMany("RequestItems")
                        .HasForeignKey("ItemGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Request", "Request")
                        .WithMany("RequestItems")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.HardwareItem", b =>
                {
                    b.HasOne("DataPlanning.Data.PropertyRecord", "PropertyRecord")
                        .WithMany("HardwareItems")
                        .HasForeignKey("PropertyRecordId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.NsnItem", b =>
                {
                    b.HasOne("DataPlanning.Data.Site", "Site")
                        .WithMany("NsnItems")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.SerializedItem", b =>
                {
                    b.HasOne("DataPlanning.Data.PropertyRecord", "PropertyRecord")
                        .WithMany("SerializedItems")
                        .HasForeignKey("PropertyRecordId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.SoftwareItem", b =>
                {
                    b.HasOne("DataPlanning.Data.Site", "Site")
                        .WithMany("SoftwareItems")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
