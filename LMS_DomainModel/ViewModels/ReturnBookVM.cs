using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class ReturnBookVM
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public string studentName { get; set; }
        public int librarianId { get; set; }
        public string librarianName { get; set; }
        public int bookId { get; set; }
        public string bookTitle { get; set; }
        public DateTime returnDate { get; set; }
        public string DeliveryStatus { get; set; }
        public float fine { get; set; }
    }
}
