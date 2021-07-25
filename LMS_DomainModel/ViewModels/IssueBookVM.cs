using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class IssueBookVM
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public string studentName { get; set; }
        public int librarianId { get; set; }
        public string librarianName { get; set; }
        public int bookId { get; set; }
        public string bookName { get; set; }
        public int fineId { get; set; }
        public float fineValue { get; set; }
        public string issueDate { get; set; }
        public string returnDate { get; set; }
    }
}
