using AutoMapper;
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
    public class StaffRoleController : ControllerBase
    {
        public readonly IMapper mapper1;
        public StaffRoleController(DbStoreContext context, IMapper mapper)
        {
            _context = context;
            mapper1 = mapper;
        }
        DbStoreContext _context;

        [HttpGet("staffroles")]
        public IActionResult getItems()
        {
            //var result = _context.staffs.Include(l=>l.Role).Where(x=>x.RoleId== ( num =_context.staffs.Select(x=>x.RoleId))).ToList();
            var result = _context.staffs.Include(l => l.Role).ToList();
            List<StaffRoleModel> staffModels = mapper1.Map<List<StaffRoleModel>>(result);
            return Ok(staffModels);
        }
    }
}
