using DbStore.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.UI
{
    public class AddingData
    {
        public static void StaffData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.staffs.AddRange(
                    new Data.Staff { First_Name = "Henry", Last_Name = "Dsouza", Gender = "M", Phone_Number = "7865435678", Salary = 5000, RoleId = 2, AddressId = 2 },
                    new Data.Staff { First_Name = "Natasha", Last_Name = "Sharma", Gender = "F", Phone_Number = "7865435672", Salary = 3000, RoleId = 1, AddressId = 3 },
                    new Data.Staff { First_Name = "Shruti", Last_Name = "Bakshi", Gender = "F", Phone_Number = "7865436678", Salary = 5000, RoleId = 2, AddressId = 4 },
                    new Data.Staff { First_Name = "Medha", Last_Name = "Gupta", Gender = "F", Phone_Number = "7865465672", Salary = 3000, RoleId = 1, AddressId = 1 },
                    new Data.Staff { First_Name = "Sanjeev", Last_Name = "Sharma", Gender = "M", Phone_Number = "7868435672", Salary = 15000, RoleId = 3, AddressId = 5 }
            );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void AddressData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.addresses.AddRange(
                    new Data.Address { AddressLine1 = "127/71", AddressLine2 = "saket nagar", City = "Kanpur", State = "UP", Pincode = "208014" },
                    new Data.Address { AddressLine1 = "b-31", AddressLine2 = "AWAS VIKAS ", City = "Kanpur", State = "UP", Pincode = "208014" },
                    new Data.Address { AddressLine1 = "H-281", AddressLine2 = "Sector 62", City = "Noida", State = "UP", Pincode = "208014" },
                    new Data.Address { AddressLine1 = "127/17", AddressLine2 = "Kidwai nagar", City = "Kanpur", State = "UP", Pincode = "208012" },
                    new Data.Address { AddressLine1 = "123/62", AddressLine2 = "Govind nagar", City = "Lucknow", State = "UP", Pincode = "208011" }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void RoleData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.roles.AddRange(
                    new Data.Role { Rolename = "Working Staff", Description = "working with products" },
                    new Data.Role { Rolename = "Reception Staff", Description = "biling counter" },
                    new Data.Role { Rolename = "Manager", Description = "management of workers" }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void InventoryData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.inventories.AddRange(
                    new Data.Inventory { ProductId = 1, TotalQuantity = 21 },
                    new Data.Inventory { ProductId = 2, TotalQuantity = 30 },
                    new Data.Inventory { ProductId = 3, TotalQuantity = 12 }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void ProductCategoryData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.productCategories.AddRange(
                   new Data.ProductCategory { ProductId = 1, CategoryId = 1 },
                   new Data.ProductCategory { ProductId = 2, CategoryId = 3 },
                   new Data.ProductCategory { ProductId = 3, CategoryId = 2 }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void ProductData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.products.AddRange(
                    new Data.Product { ProductName = "Laptop", ProductInStock = true, Manufacturer = "Dell", ProductCode = "LAP0", CategoryId = 1 },
                   new Data.Product { ProductName = "Tshirt", ProductInStock = false, Manufacturer = "Allen Solly", ProductCode = "TS10", CategoryId = 3 },
                   new Data.Product { ProductName = "Yougurt", ProductInStock = true, Manufacturer = "Amul", ProductCode = "YOG10", CategoryId = 2 }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void SupplierData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.suppliers.AddRange(
                    new Data.Supplier { SupplierName = "Hina", SupplierAge = 29, SupplierEmail = "hina@gmail.com", SupplierGender = "F", SupplierPhonenumber = "657853890" },
                    new Data.Supplier { SupplierName = "Akash", SupplierAge = 49, SupplierEmail = "akash@gmail.com", SupplierGender = "M", SupplierPhonenumber = "659953890" },
                    new Data.Supplier { SupplierName = "Harsh", SupplierAge = 39, SupplierEmail = "harsh@gmail.com", SupplierGender = "M", SupplierPhonenumber = "657887890" },
                    new Data.Supplier { SupplierName = "Shvani", SupplierAge = 42, SupplierEmail = "shivani@gmail.com", SupplierGender = "F", SupplierPhonenumber = "657653890" }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void CategoryData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.categories.AddRange(
                    new Data.Category { CategoryName = "Technology Items", CategoryCode = "TECH" },
                    new Data.Category { CategoryName = "Dairy Items", CategoryCode = "DAIR" },
                    new Data.Category { CategoryName = "Wordrobe Items", CategoryCode = "WORD" }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void ProductPriceData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.productPrices.AddRange(
                    new Data.ProductPrice { ProductId = 1, CostPrice = 20000, SellingPrice = 23000, IsActive = true, Month = new DateTime(2020, 01, 12) },
                    new Data.ProductPrice { ProductId = 1, CostPrice = 2500, SellingPrice = 2599, IsActive = false, Month = new DateTime(2020, 02, 11) },
                    new Data.ProductPrice { ProductId = 1, CostPrice = 20, SellingPrice = 24, IsActive = true, Month = new DateTime(2020, 05, 23) }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void ProductOrderData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.productOrders.AddRange(
                    new Data.ProductOrder { OrderTime = new DateTime(2021, 01, 11), Qunatity = 22 },
                    new Data.ProductOrder { OrderTime = new DateTime(2021, 05, 15), Qunatity = 10 },
                    new Data.ProductOrder { OrderTime = new DateTime(2021, 03, 17), Qunatity = 3 },
                    new Data.ProductOrder { OrderTime = new DateTime(2020, 01, 11), Qunatity = 2 }
                    );
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");
            }
        }
        public static void SupplierProductOrderData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                context.supplierProductOrders.AddRange(
                new Data.SupplierProductOrder { ProductId = 1, ProductOrderId = 2, SupplierId = 4 },
                new Data.SupplierProductOrder { ProductId = 2, ProductOrderId = 3, SupplierId = 2 },
                new Data.SupplierProductOrder { ProductId = 3, ProductOrderId = 2, SupplierId = 3 },
                new Data.SupplierProductOrder { ProductId = 1, ProductOrderId = 1, SupplierId = 3 });
                context.SaveChanges();
                Console.WriteLine("DATA ADDED");

            }
        }
    }
}
