using AutoMapper;
using DbStore.Data;
using DbStoreAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbStoreAPI.Mapper
{
    public class StaffRoleProfile:Profile
    {
        public StaffRoleProfile()
        {
            this.CreateMap<Staff,StaffRoleModel>().ForMember(des=> des.Rolename, x=> x.MapFrom(src=> src.Role.Rolename))
                .ForMember(des => des.Description, x => x.MapFrom(src => src.Role.Description)).ReverseMap();
        }
    }
}
