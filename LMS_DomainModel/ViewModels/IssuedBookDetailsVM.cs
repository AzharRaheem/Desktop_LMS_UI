using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    class IssuedBookDetailsVM
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public int bookId { get; set; }
        public int fineId { get; set; }
        public int librarianId { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime returnDate { get; set; }
    }
}
