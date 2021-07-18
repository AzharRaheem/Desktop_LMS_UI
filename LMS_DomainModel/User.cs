using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(40)]
        public string firstName { get; set; }
        [Required]
        [StringLength(40)]
        public string lastName { get; set; }
        [Required]
        [StringLength(50)]
        public string email { get; set; }
        [Required]
        [StringLength(200)]
        public string password { get; set; }
        [Required]
        public int gender { get; set; }
        [StringLength(600)]
        public string profileImagePath { get; set; }
        [ForeignKey("role")]
        [DefaultValue(1)]
        public int? roleId { get; set; }
        public Role role { get; set; }
    }
}
