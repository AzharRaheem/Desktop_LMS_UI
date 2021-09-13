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
    public class ReturnBookBL
    {
        ReturnBookRepo returnBookRepo;
        public ReturnBookBL()
        {
            returnBookRepo = new ReturnBookRepo();
        }

        public BaseViewModel GetAllStudents()
        {
            return returnBookRepo.GetAllStudentsFromDB();
        }

        public BaseViewModel GetAllBooks()
        {
            return returnBookRepo.GetAllBooksFromDB();
        }

        public IssueBook isIssuedBook(int bookId, int studentId)
        {
            return returnBookRepo.IssuedBookDetailsFromDB(bookId , studentId);
        }

        public object GetAllReturnedBooks()
        {
            return returnBookRepo.GetAllReturnedBooksFromDB();
        }

        public float GetFineValue(int fineId)
        {
            return returnBookRepo.GetFineValueFromDB(fineId);
        }

        public BaseViewModel SaveReturnBook(ReturnBook returnBook)
        {
            return returnBookRepo.SaveReturnBookInDB(returnBook);
        }

        public ReturnBookBaseVM GetAllReturnedBooksRecord()
        {
            return returnBookRepo.GetAllRecordsFromDB();
        }

        public BaseViewModel DeleteReturnedBookRecord(int id)
        {
            return returnBookRepo.DeleteReturnedBookRecordFromDB(id);
        }
    }
}
