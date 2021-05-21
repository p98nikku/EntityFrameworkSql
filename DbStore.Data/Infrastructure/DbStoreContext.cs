using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data.Infrastructure
{
    public class DbStoreContext:DbContext
    {
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Inventory> inventories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<ProductPrice> productPrices { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
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
            modelBuilder.Entity<Inventory>().HasNoKey();
            modelBuilder.Entity<Inventory>().HasIndex(r => r.ProductId).IsUnique();
            modelBuilder.Entity<Inventory>().Property(k => k.TotalQuantity);


            //managing the productcategory table
            modelBuilder.Entity<ProductCategory>().HasKey(k => new { k.ProductId, k.CategoryId });


            //managing the product price table
            modelBuilder.Entity<ProductPrice>().HasKey(k => k.ProductPriceId);
            modelBuilder.Entity<ProductPrice>().Property(k => k.ProductId).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(k => k.CostPrice).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(k => k.SellingPrice).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(k => k.Month).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(k => k.IsActive).IsRequired();


            //managing the supplier table
            modelBuilder.Entity<Supplier>().HasKey(k => k.SupplierId);
            modelBuilder.Entity<Supplier>().Property(k => k.SupplierName).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Supplier>().Property(k => k.SupplierAge).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Supplier>().Property(k => k.SupplierEmail).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Supplier>().Property(k=>k.SupplierPhonenumber).HasMaxLength(10).IsRequired().IsFixedLength();
            modelBuilder.Entity<Supplier>().Property(k => k.SupplierGender).HasMaxLength(10).IsRequired();


            //managing the product table
            modelBuilder.Entity<Product>().HasKey(k => k.ProductId);
            modelBuilder.Entity<Product>().Property(k=>k.ProductName).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Product>().Property(k => k.ProductInStock).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(k => k.Manufacturer).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Product>().Property(k => k.ProductCode).HasMaxLength(4).IsRequired();
            modelBuilder.Entity<Product>().Property(k => k.CategoryId).IsRequired();


            //managing the category table
            modelBuilder.Entity<Category>().HasKey(k => k.CategoryId);
            modelBuilder.Entity<Category>().Property(k => k.CategoryName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Category>().Property(k => k.CategoryCode).HasMaxLength(4).IsRequired();
        }
    }
}
