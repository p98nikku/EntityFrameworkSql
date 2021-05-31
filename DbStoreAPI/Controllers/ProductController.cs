using AutoMapper;
using DbStore.Data;
using DbStore.Data.Infrastructure;
using DbStoreAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IMapper mapper1;
        public ProductController(DbStoreContext context, IMapper mapper)
        {
            _context = context;
            mapper1 = mapper;   
        }
        DbStoreContext _context;

        [HttpGet("products")]
        public IActionResult getProductItems()
        {
            var result = _context.products.ToList();
            return Ok(result);
        }

        [HttpGet("products")]
        public IActionResult getItems()
        {
            var result = _context.products.ToList();
            List<ProductModel> productModels = mapper1.Map<List<ProductModel>>(result);
            return Ok(result);
        }

        [HttpPost("products")]
        public IActionResult postProduct(Product item)
        {
            _context.products.Add(item);
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpPut("products/{id}")]
        public IActionResult updateProduct(int id, Product item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("products/{id}")]
        public IActionResult deleteProduct(int id)
        {
            var res = _context.products.Find(id);
            _context.products.Remove(res);
            _context.SaveChanges();
            return Ok(res);
        }
    }
}
