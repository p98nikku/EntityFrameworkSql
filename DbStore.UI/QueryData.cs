using DbStore.Data;
using DbStore.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DbStore.UI
{
    public class QueryData
    {
        public static void StaffQueryNamePhoneNumber()
        {
            using(DbStoreContext context = new DbStoreContext())
            {
                var q = (from Staff in context.staffs 
                        where Staff.Phone_Number== "7865435678" || Staff.First_Name== "Shruti"
                         select new { Staff }).ToList();
                foreach(var stafflist in q)
                {
                    Console.WriteLine($"{stafflist.Staff.First_Name},{stafflist.Staff.Last_Name}");
                }
            }
        }
        public static void StaffRole()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                var q = from Staff in context.staffs
                        join role in context.roles
                        on Staff.RoleId equals role.RoleId
                        select new { Staff, role };
                foreach(var detail in q)
                {
                    Console.WriteLine($"{detail.Staff.First_Name},{detail.Staff.Last_Name},{detail.role.Rolename}");
                }
            }
        }
        public static void ProductInStock()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                var q = from Product in context.products
                        where Product.ProductInStock == true
                        select new { Product };
                foreach (var details in q)
                {
                    Console.WriteLine($"{details.Product.ProductName},{details.Product.Manufacturer},{details.Product.ProductCode}");
                }
            }
        }
        public static void ProductCategoryPrice()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                var q = from Product in context.products
                        join ProductCategory in context.productCategories
                        on Product.ProductId equals ProductCategory.ProductId
                        join Category in context.categories
                        on ProductCategory.CategoryId equals Category.CategoryId
                        select new { Product, Category };
                foreach(var details in q)
                {
                    Console.WriteLine($"{details.Product.ProductName},{details.Product.Manufacturer},{details.Category.CategoryName},{details.Category.CategoryCode}");
                }
            }
        }
        public static void ProductinCategory()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                var q = from Product in context.products
                        join ProductCategory in context.productCategories
                        on Product.ProductId equals ProductCategory.ProductId
                        join Category in context.categories
                        on ProductCategory.CategoryId equals Category.CategoryId
                        where Category.CategoryCode == "TECH"
                        select new { Product, Category };
                foreach (var details in q)
                {
                    Console.WriteLine($"{details.Product.ProductName},{details.Product.Manufacturer},{details.Category.CategoryName},{details.Category.CategoryCode}");
                }
            }
        }
        public static void SuppliersData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                var q =  from supplier in context.Set<Supplier>() join supplireprodorder in context.Set<SupplierProductOrder>() on
                            supplier.SupplierId equals supplireprodorder.SupplierId join prodt in context.Set<Product>() on
                            supplireprodorder.ProductId equals prodt.ProductId 
                            join prodorder in context.Set<ProductOrder>() on
                            supplireprodorder.ProductOrderId equals prodorder.ProductOrderId
                            select(new { supplier, prodorder, prodt});
                foreach (var details in q)
                {
                    Console.WriteLine($"{details.supplier.SupplierName},{details.supplier.SupplierEmail},{details.supplier.SupplierPhonenumber}" +
                        $"{details.supplier.SupplierAge},{details.prodt.ProductName}");
                }
            }
        }
        public static void SupplierProductRecentDatesData()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                var q = from supplier in context.Set<Supplier>()
                        join supplierorder in context.Set<SupplierProductOrder>() on
                        supplier.SupplierId equals supplierorder.SupplierId
                        join prodt in context.Set<Product>() on
                        supplierorder.ProductId equals prodt.ProductId
                        join prodorder in context.Set<ProductOrder>() on
                        supplierorder.ProductOrderId equals prodorder.ProductOrderId
                        where prodorder.OrderTime.Date>= new DateTime(2021,04,01) 
                        select (new { supplier, prodorder, prodt });
                foreach (var details in q)
                {
                    Console.WriteLine($"{details.supplier.SupplierName},{details.supplier.SupplierEmail},{details.supplier.SupplierPhonenumber}" +
                        $"{details.supplier.SupplierAge},{details.prodt.ProductName}");
                }
            }
        }
        public static void ProductCategoryInAscending()
        {
            using (DbStoreContext context = new DbStoreContext())
            {
                var query = from category in context.Set<Category>()
                            join prodcategory in context.Set<ProductCategory>() on
                            category.CategoryId equals prodcategory.CategoryId
                            join product in context.Set<Product>() on
                            prodcategory.ProductId equals product.ProductId
                            group product by category.CategoryId into x
                            orderby x.Count<Product>() descending
                            select (new { count = x.Count<Product>(), CategoryId = x.Key });
                foreach (var details in query)
                {
                    Console.WriteLine($"{details.CategoryId} {details.count}");
                }
            }

        }
    }
}
