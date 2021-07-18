using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class UserRoleVM
    {
        public int id { get; set; }
        public string profileImagePath { get; set; }
        public object profileImage { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int gender { get; set; }
        public string genderString { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
    }
}
