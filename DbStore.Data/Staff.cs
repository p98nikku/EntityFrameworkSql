using System;
using System.Collections.Generic;
using System.Text;

namespace DbStore.Data
{
    public class Staff
    {
        public long StaffId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public string Phone_Number { get; set; }
        public long AddressId { get; set; }
        public int RoleId { get; set; }
        public long Salary { get; set; }
        public Role Role { get; set; }
        public Address Address { get; set; }
    }
}
