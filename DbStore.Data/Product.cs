using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool ProductInStock { get; set; }
        public string Manufacturer { get; set; }
        public string ProductCode { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
