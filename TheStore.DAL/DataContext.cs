using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            modelBuilder.Entity<OrderDetail>().HasNoKey();
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
