using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace LMS_DomainModel
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        [StringLength(30)]
        public string name { get; set; }

        public List<User> users { get; set; }
    }
}
