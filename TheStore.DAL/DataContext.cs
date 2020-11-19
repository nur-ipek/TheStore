using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheStore.Core.Models;
using TheStore.Data.Configurations;

namespace TheStore.DAL.Concrete.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Entity<OrderDetail>()
                .HasOne(p => p.Order)
                .WithMany(w => w.OrderDetails)
                .HasForeignKey(f => f.OrderId);

            modelBuilder.Entity<Product>()
                .Property(b => b.UnitPrice).HasColumnType("decimal");

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Seller)
                .WithOne(s => s.Order)
                .HasForeignKey<Order>(l => l.SellerId);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Customer)
                .WithMany(w => w.Orders)
                .HasForeignKey(f => f.CustomerId);

            modelBuilder.Entity<Town>()
                .HasOne(p => p.City)
                .WithMany(w => w.Towns)
                .HasForeignKey(f => f.CityId);
                

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<Town> Towns { get; set; }
    }
}
