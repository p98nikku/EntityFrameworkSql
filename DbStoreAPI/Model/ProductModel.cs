using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbStoreAPI.Model
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public bool ProductInStock { get; set; }
        public string Manufacturer { get; set; }
    }
}
