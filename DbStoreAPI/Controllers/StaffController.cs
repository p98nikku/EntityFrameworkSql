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
    public class StaffController : ControllerBase
    {
        public readonly IMapper mapper1;
        public StaffController(DbStoreContext context,IMapper mapper)
        {
            _context = context;
            mapper1 = mapper;
        }
        DbStoreContext _context;

        [HttpGet("staffs")]
        public IActionResult getItems()
        {
            var result = _context.staffs.ToList();
           // List<StaffModel> staffModels = mapper1.Map<List<StaffModel>>(result);
            return Ok(result);
        }

        //[HttpGet("staffs")]
        //public IActionResult getItems()
        //{
        //    var result = _context.staffs.ToList();
        //    List<StaffModel> staffModels = mapper1.Map<List<StaffModel>>(result);
        //    return Ok( staffModels);
        //}

        [HttpPost("staffs")]
        public IActionResult postItems(Staff item)
        {
            _context.staffs.Add(item);
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpPut("staffs/{id}")]
        public IActionResult updateStaff(int id, Staff item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(item);
        }
    }
}
