using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public int TotalQuantity { get; set; }
        public Product product { get; set; }
    }
}
