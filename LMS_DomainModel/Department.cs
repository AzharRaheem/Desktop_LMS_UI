using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel
{
    public class Department
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public List<Student> students { get; set; }
    }
}
