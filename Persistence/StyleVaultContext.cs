using Microsoft.EntityFrameworkCore;
using StyleVault.Core;
using System;

namespace Persistence
{
    public class StyleVaultContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public StyleVaultContext(DbContextOptions<StyleVaultContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Vendor>().HasKey(v => v.Id);
            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<OrderDetail>().HasKey(od => od.Id);

            // Product and Vendor Relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Vendor)
                .WithMany(v => v.Products)
                .HasForeignKey(p => p.VendorId);

            // Order and OrderDetail Relationship
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrdersDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId);

            // OrderDetail and Product Relationship
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId);
        }
    }
}
