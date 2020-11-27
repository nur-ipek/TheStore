using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheStore.Core.Models;

namespace TheStore.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembershipType>().HasData(
                    new MembershipType
                    {
                        Id = 1,
                        Name = "Individual"
                    }
                );

            modelBuilder.Entity<MembershipType>().HasData(
                    new MembershipType
                    {
                        Id = 2,
                        Name = "Sole Proprietorship"
                    }
                );

            modelBuilder.Entity<MembershipType>().HasData(
                    new MembershipType
                    {
                        Id = 3,
                        Name = "Limited or Incorporated"
                    }
                );

            modelBuilder.Entity<City>().HasData(
                    new City
                    {
                        Id = 1,
                        Name = "Adana"
                    }
                );

            modelBuilder.Entity<City>().HasData(
                    new City
                    {
                        Id = 2,
                        Name = "Adıyaman"
                    }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    FirstName = "Burak",
                    LastName = "Akkaya",
                    UserName = "akkayaburak",
                    Address = "Bilmem Mah. Bilmem Sk.",
                    PhoneNumber = 5457778899,
                    Birthdate = DateTime.Parse("06/01/1996"),
                    CityId = 1,
                    IsActive = true
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 2,
                    FirstName = "Nur İpek",
                    LastName = "Yılmaz",
                    UserName = "ipekyilmaz",
                    Address = "Bilmem Mah. Bilmem Sk.",
                    PhoneNumber = 5368887755,
                    Birthdate = DateTime.Parse("08/10/1997"),
                    CityId = 2,
                    IsActive = true
                }
            );

            modelBuilder.Entity<Seller>().HasData(
                new Seller
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Koçak",
                    StoreName = "Kardeşler",
                    PhoneNumber = 5554448866,
                    Adress = "Bilmem Mah. Bilmem Sk.",
                    IdentityNumber = 11111111111,
                    MembershipTypeId = 1,
                    CityId = 1
                }
            );

            modelBuilder.Entity<Seller>().HasData(
               new Seller
               {
                   Id = 2,
                   FirstName = "Veli",
                   LastName = "Kara",
                   StoreName = "Karalar",
                   PhoneNumber = 5445551122,
                   Adress = "Bilmem Mah. Bilmem Sk.",
                   IdentityNumber = 11111111112,
                   MembershipTypeId = 1,
                   CityId = 2
               }
            );

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType
                {
                    Id = 1,
                    Name = "T-Shirt"
                }
            );

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType
                {
                    Id = 2,
                    Name = "Jean"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
               {
                   Id = 1,
                   Name = "New style jean",
                   ProductTypeId = 2,
                   Description = "New season 2020 Autumn",
                   UnitPrice = 200,
                   Stock = 10,
                   BodySize = 33,
                   SellerId = 1,
                   IsDelete = false
               }
           );

            modelBuilder.Entity<Product>().HasData(
                new Product
              {
                  Id = 2,
                  Name = "V-neck t-shirt",
                  ProductTypeId = 1,
                  Description = "New season 2020 Autumn",
                  UnitPrice = 70,
                  Stock = 20,
                  BodySize = 20,
                  SellerId = 1,
                  IsDelete = false
              }
          );

            modelBuilder.Entity<Order>().HasData(
                new Order
             {
                 Id = 1,
                 CustomerId = 1,
                 SellerId = 1,
                 OrderedDate = DateTime.Parse("25/11/2020")
             }
          );

            modelBuilder.Entity<Order>().HasData(
                new Order
           {
               Id = 2,
               CustomerId = 2,
               SellerId = 2,
               OrderedDate = DateTime.Parse("25/11/2020")
           }
        );

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail
         {
             Id = 1,
             OrderId = 1,
             ProductId = 1
         }
        );

            modelBuilder.Entity<Town>().HasData(
            new Town
            {
                Id = 1,
                Name = "Çelikhan",
                CityId = 2
            }
        );

            modelBuilder.Entity<Town>().HasData(
           new Town
           {
               Id = 2,
               Name = "Çukurova",
               CityId = 1
           }
        );



        }
    }
}
