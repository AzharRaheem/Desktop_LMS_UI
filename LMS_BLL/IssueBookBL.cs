using LMS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;
using LMS_DomainModel;

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

        public BaseViewModel SaveIssueBook(IssueBook issueBook)
        {
            return issueBookRepo.SaveIssueBookInDB(issueBook);
        }

        public IssueBookBaseVM GetAllIssuedBooks()
        {
            return issueBookRepo.GetAllIssuedBooksFromDB();
        }

        public BaseViewModel DeleteRecord(int issuedBookId)
        {
            return issueBookRepo.DeleteRecordFromDB(issuedBookId);
        }

        public BaseViewModel UpdateRecord(IssueBook issueBook)
        {
            return issueBookRepo.UpdateRecordInDB(issueBook);
        }
    }
}
