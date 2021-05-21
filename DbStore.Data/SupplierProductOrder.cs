using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data
{
    public class SupplierProductOrder
    {
        public int ProductOrderId { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
        public ProductOrder ProductOrder { get; set; }
    }
}
