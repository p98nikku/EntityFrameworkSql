using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data.Infrastructure
{
    public class DbStoreContext:DbContext
    {
        DbSet<Staff> staffs { get; set; }
        DbSet<Role> roles { get; set; }
        DbSet<Address> addresses { get; set; }
        DbSet<Category> categories { get; set; }
        DbSet<Inventory> inventories { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<ProductCategory> productCategories { get; set; }
        DbSet<ProductPrice> productPrices { get; set; }
        DbSet<Supplier> suppliers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
           optionsBuilder.UseNpgsql("Host=localhost;DataBase=DStore;username=postgres;password=Neetika2021");
            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //managing staff table
            modelBuilder.Entity<Staff>().HasKey(r => r.StaffId);
            modelBuilder.Entity<Staff>().Property(r => r.First_Name).HasMaxLength(30).IsRequired().IsFixedLength();
            modelBuilder.Entity<Staff>().Property(r => r.Last_Name).HasMaxLength(30).IsRequired().IsFixedLength();
            modelBuilder.Entity<Staff>().Property(r => r.Gender).HasMaxLength(1).IsRequired().IsFixedLength();
            modelBuilder.Entity<Staff>().Property(r => r.Phone_Number).HasMaxLength(10).IsRequired().IsFixedLength();
            modelBuilder.Entity<Staff>().Property(r => r.AddressId).IsRequired();
            modelBuilder.Entity<Staff>().Property(r => r.RoleId).IsRequired();
            modelBuilder.Entity<Staff>().Property(r => r.Salary).IsRequired();

            //managing the address table
            modelBuilder.Entity<Address>().HasKey(k => k.AddressId);
            modelBuilder.Entity<Address>().Property(r => r.AddressLine1).HasMaxLength(128).IsRequired().IsFixedLength();
            modelBuilder.Entity<Address>().Property(r => r.AddressLine2).HasMaxLength(128).IsRequired().IsFixedLength();
            modelBuilder.Entity<Address>().Property(r => r.Pincode).HasMaxLength(6).IsRequired().IsFixedLength();
            modelBuilder.Entity<Address>().Property(r => r.City).HasMaxLength(50).IsRequired().IsFixedLength();
            modelBuilder.Entity<Address>().Property(r => r.State).HasMaxLength(50).IsRequired().IsFixedLength();


            //managing the role table
            modelBuilder.Entity<Role>().HasKey(k => k.RoleId);
            modelBuilder.Entity<Role>().Property(r => r.Rolename).HasMaxLength(50).IsRequired().IsFixedLength();
            modelBuilder.Entity<Role>().Property(r => r.Description).HasMaxLength(128).IsRequired().IsFixedLength();

            //managing the inventory table
            modelBuilder.Entity<Inventory>().HasKey(k => k.ProductId);
            //managing the productcategory table
            modelBuilder.Entity<ProductCategory>().HasKey(k => new { k.ProductId , k.CategoryId});
            //managing the product price table
            modelBuilder.Entity<ProductPrice>().HasKey(k => k.ProductPriceId);
            //managing the supplier table
            modelBuilder.Entity<Supplier>().HasKey(k => k.SupplierId);
            //managing the product table
            modelBuilder.Entity<Product>().HasKey(k => k.ProductId);
            //managing the category table
            modelBuilder.Entity<Category>().HasKey(k => k.CategoryId);
        }
    }
}
