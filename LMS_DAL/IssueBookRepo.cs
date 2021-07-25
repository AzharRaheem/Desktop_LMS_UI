using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;

namespace LMS_DAL
{
    public class IssueBookRepo
    {
        LMSDbContext db;
        public IssueBookRepo()
        {
            db = new LMSDbContext();
        }

        public BaseViewModel GetAllBooksFromDB()
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                result.data = db.Books.ToList();
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel GetAllFinesFromDB()
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                result.data = db.fines.ToList();
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel DeleteRecordFromDB(int issuedBookId)
        {
            try
            {
                var record = db.issuedBooks.Where(ib => ib.id == issuedBookId).FirstOrDefault();
                db.issuedBooks.Remove(record);
                db.SaveChanges();
                return new BaseViewModel() { isSuccess = true, data = null, message = "Issued Book Record Deleted Successfully."};
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, message = ex.Message, data = null };
            }
            
        }

        public BaseViewModel UpdateRecordInDB(IssueBook issueBook)
        {
            try
            {
                var record = db.issuedBooks.Where(ib => ib.id == issueBook.id).FirstOrDefault();
                record.id = issueBook.id;
                record.studentId = issueBook.studentId;
                record.bookId = issueBook.bookId;
                record.fineId = issueBook.fineId;
                record.librarianId = issueBook.librarianId;
                record.issueDate = issueBook.issueDate;
                record.returnDate = issueBook.returnDate;
                db.SaveChanges();
                return new BaseViewModel() { isSuccess = true, data = null, message = "Record Updated Successfully." };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, message = ex.Message, data = null };
            }
        }

        public IssueBookBaseVM GetAllIssuedBooksFromDB()
        {
            IssueBookBaseVM result = new IssueBookBaseVM();
            try
            {
                var allIssuedBooks = db.issuedBooks.ToList();
                result.issueBooks = new List<IssueBookVM>();
                foreach (var record in allIssuedBooks)
                {
                    IssueBookVM issuebook = new IssueBookVM();
                    issuebook.id = record.id;
                    issuebook.bookId = record.bookId;
                    var book = db.Books.Where(b => b.id == issuebook.bookId).First();
                    issuebook.bookName = book.bookName;
                    issuebook.studentId = record.studentId;
                    var student = db.Students.Where(s => s.id == issuebook.studentId).First();
                    issuebook.studentName = student.name;
                    issuebook.fineId = record.fineId;
                    var fineData = db.fines.Where(f => f.id == issuebook.fineId).First();
                    issuebook.fineValue = fineData.fine;
                    issuebook.librarianId = record.librarianId;
                    var Librarian = db.Users.Where(u => u.id == issuebook.librarianId).First();
                    issuebook.librarianName = Librarian.firstName + " " + Librarian.lastName;
                    issuebook.issueDate = record.issueDate.ToLongDateString();
                    issuebook.returnDate = record.returnDate.ToLongDateString();
                    result.issueBooks.Add(issuebook);
                }
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel SaveIssueBookInDB(IssueBook issueBook)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                db.issuedBooks.Add(issueBook);
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Book Issued Successfully.\nCollec Book from Librarian.";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel GetAllStudentsFromDB()
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                result.data = db.Students.ToList();
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }
    }
}
