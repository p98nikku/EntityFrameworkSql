using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product product { get; set; }
        public Category category { get; set; }
    }
}
