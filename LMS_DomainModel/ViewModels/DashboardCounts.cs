using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_DomainModel.ViewModels
{
    public class DashboardCounts
    {
        public bool isSuccess { get; set; }
        public string message { get; set; }
        public int rolesCount { get; set; }
        public int usersCount { get; set; }
        public int booksCount { get; set; }
        public int studentsCount { get; set; }
        public int issueBooksCount { get; set; }
        public int returnedBooksCount { get; set; }
    }
}
