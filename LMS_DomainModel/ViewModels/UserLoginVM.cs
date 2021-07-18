using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class UserLoginVM
    {
        public int id { get; set; }
        public string loginUserFirstName {get; set; }
        public string loginUserLastName { get; set; }
        public int userRoleId { get; set; }
        public string roleName { get; set; }
        public string profileImagePath { get; set; }

        public string message { get; set; }
        public bool isSuccess { get; set; }
    }
}
