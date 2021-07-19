using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel
{
    public class Fine
    {
        [Key]
        public int id { get; set; }
        [Required]
        public float fine { get; set; }
    }
}
