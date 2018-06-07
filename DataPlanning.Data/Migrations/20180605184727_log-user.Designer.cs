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
    [Migration("20180605184727_log-user")]
    partial class loguser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataPlanning.Data.Attachment", b =>
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

                    b.ToTable("Attachment");
                });

            modelBuilder.Entity("DataPlanning.Data.Bucket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BucketCategoryId");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("BucketCategoryId");

                    b.HasIndex("RequestId");

                    b.ToTable("Bucket");
                });

            modelBuilder.Entity("DataPlanning.Data.BucketCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("BucketCategory");
                });

            modelBuilder.Entity("DataPlanning.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BucketId");

                    b.Property<double>("Cost");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("BucketId");

                    b.HasIndex("RequestId");

                    b.ToTable("Item");
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

            modelBuilder.Entity("DataPlanning.Data.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("Priority");
                });

            modelBuilder.Entity("DataPlanning.Data.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorizedRegulation");

                    b.Property<DateTime>("DateSubmitted");

                    b.Property<Guid>("Guid");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("PriorityId");

                    b.Property<int>("RequestorId");

                    b.Property<string>("Requirement");

                    b.Property<int>("SiteId");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.HasIndex("PriorityId");

                    b.HasIndex("RequestorId");

                    b.HasIndex("SiteId");

                    b.ToTable("Request");
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

            modelBuilder.Entity("DataPlanning.Data.Attachment", b =>
                {
                    b.HasOne("DataPlanning.Data.Request", "Request")
                        .WithMany("Attachments")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.Bucket", b =>
                {
                    b.HasOne("DataPlanning.Data.BucketCategory", "BucketCategory")
                        .WithMany("Buckets")
                        .HasForeignKey("BucketCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Request", "Request")
                        .WithMany("Buckets")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.Item", b =>
                {
                    b.HasOne("DataPlanning.Data.Bucket", "Bucket")
                        .WithMany("Items")
                        .HasForeignKey("BucketId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Request", "Request")
                        .WithMany("Items")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.LogUser", b =>
                {
                    b.HasOne("DataPlanning.Data.Site")
                        .WithMany("LogUsers")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User")
                        .WithMany("LogUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DataPlanning.Data.Request", b =>
                {
                    b.HasOne("DataPlanning.Data.Priority", "Priority")
                        .WithMany("Requests")
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.User", "Requestor")
                        .WithMany("Requests")
                        .HasForeignKey("RequestorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DataPlanning.Data.Site", "Site")
                        .WithMany("Requests")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
