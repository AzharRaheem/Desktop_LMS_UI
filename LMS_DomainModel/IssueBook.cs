using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel
{
    public class IssueBook
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("student")]
        public int studentId { get; set; }
        public Student student { get; set; }
        [ForeignKey("book")]
        public int bookId { get; set; }
        public Book book { get; set; }
        [ForeignKey("fineRecord")]
        public int fineId { get; set; }
        public Fine fineRecord { get; set; }
        [ForeignKey("librarian")]
        public int librarianId { get; set; }
        public User librarian { get; set; }

        public DateTime issueDate { get; set; }
        public DateTime returnDate { get; set; }
    }
}
