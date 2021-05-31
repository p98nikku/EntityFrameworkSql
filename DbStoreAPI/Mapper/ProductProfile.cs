using AutoMapper;
using DbStore.Data;
using DbStoreAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbStoreAPI.Mapper
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            this.CreateMap <Product,ProductModel>();

        }
    }
}
