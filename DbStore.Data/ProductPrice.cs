using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data
{
    public class ProductPrice
    {
        public int ProductPriceId { get; set; }
        public int ProductId { get; set; }
        public int CostPrice { get; set; }
        public int SellingPrice { get; set; }
        public DateTime Month { get; set; }
        public Boolean IsActive { get; set; }
        public Product product { get; set; }

    }
}
