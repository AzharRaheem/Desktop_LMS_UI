using LMS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;

namespace LMS_BLL
{
    public class IssueBookBL
    {
        IssueBookRepo issueBookRepo;
        public IssueBookBL()
        {
            issueBookRepo = new IssueBookRepo();
        }

        public BaseViewModel GetAllBooks()
        {
            return issueBookRepo.GetAllBooksFromDB();
        }

        public BaseViewModel GetAllStudents()
        {
            return issueBookRepo.GetAllStudentsFromDB();
        }

        public BaseViewModel GetAllFines()
        {
            return issueBookRepo.GetAllFinesFromDB();
        }
    }
}
