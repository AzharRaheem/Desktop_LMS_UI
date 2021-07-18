using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        public int status { get; set; }

        public List<Book> books { get; set; }
    }
}
