using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ApprovalGroup> ApprovalGroups { get; set; }
        public DbSet<Approver> Approvers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<ItemGroupApproval> ItemGroupApprovals { get; set; }
        public DbSet<ItemGroupCategory> ItemGroupCategories { get; set; }
        public DbSet<LogUser> LogUsers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderAttachment> OrderAttachments { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<PropertyCustodian> PropertyCustodians { get; set; }
        public DbSet<PropertyRecord> PropertyRecords { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestAttachment> RequestAttachments { get; set; }
        public DbSet<RequestItem> RequestItems { get; set; }
        public DbSet<Site> Site { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=log-planning-dev;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasDiscriminator<string>("ItemType")
                .HasValue<Item>("Base")
                .HasValue<NsnItem>("NonSerialized")
                .HasValue<SerializedItem>("Serialized")
                .HasValue<HardwareItem>("Hardware")
                .HasValue<SoftwareItem>("Software");

            foreach (var ent in modelBuilder.Model.GetEntityTypes().Select(x => x.Name))
            {
                modelBuilder.Entity(ent).ToTable(ent.Split('.').Last());
            }

            foreach (var ent in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetReferencingForeignKeys()))
            {
                ent.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
