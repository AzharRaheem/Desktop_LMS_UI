using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string fatherName { get; set; }
        [Required]
        public DateTime dob { get; set; }
        [Required]
        public string cnic { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string contact { get; set; }
        [ForeignKey("department")]
        [Required]
        public int departmentId { get; set; }
        public Department department { get; set; }
        [Required]
        public int gender { get; set; }
        public string studentImage { get; set; }
    }
}
