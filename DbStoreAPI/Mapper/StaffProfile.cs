using AutoMapper;
using DbStore.Data;
using DbStoreAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbStoreAPI.Mapper
{
    public class StaffProfile: Profile
    {
        public StaffProfile()
        {
            this.CreateMap<Staff, StaffRoleModel>();
        }
        
    }
}
