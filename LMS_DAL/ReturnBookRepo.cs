using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;
using LMS_DomainModel;

namespace LMS_DAL
{
    public class ReturnBookRepo
    {
        LMSDbContext db;
        public ReturnBookRepo()
        {
            db = new LMSDbContext();
        }

        public BaseViewModel GetAllStudentsFromDB()
        {
            try
            {
                return new BaseViewModel() { isSuccess = true, message = "Students Data Retreived Successfully.", data = db.Students.ToList() };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, data = null, message = ex.Message };
            }
        }

        public IssueBook IssuedBookDetailsFromDB(int bookId, int studentId)
        {
            try
            {
                var record = db.issuedBooks.Where(ib => ib.bookId == bookId && ib.studentId == studentId).Single();
                return record;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object GetAllReturnedBooksFromDB()
        {
            return db.returnedBooks.ToList();
        }

        public BaseViewModel SaveReturnBookInDB(ReturnBook returnBook)
        {
            try
            {
                db.returnedBooks.Add(returnBook);
                db.SaveChanges();
                return new BaseViewModel() { isSuccess = true, data = null , message = "Record Saved Successfully." };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, data = null, message = ex.Message };
            }
        }

        public BaseViewModel DeleteReturnedBookRecordFromDB(int id)
        {
            try
            {
                var record = db.returnedBooks.Where(r => r.id == id).FirstOrDefault();
                db.returnedBooks.Remove(record);
                db.SaveChanges();
                return new BaseViewModel() { isSuccess = true, message = "Record Deleted Successfully.", data = null };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, data = null, message = ex.Message };
            }
        }

        public ReturnBookBaseVM GetAllRecordsFromDB()
        {
            ReturnBookBaseVM result = new ReturnBookBaseVM();
            try
            {
                result.allReturnedBooks = new List<ReturnBookVM>();
                var records = db.returnedBooks.ToList();
                foreach (var returnedBook in records)
                {
                    ReturnBookVM returnBookVM = new ReturnBookVM();
                    returnBookVM.id = returnedBook.id;
                    returnBookVM.librarianId = returnedBook.librarianId;
                    var librarian = db.Users.Where(u => u.id == returnedBook.librarianId).Single();
                    returnBookVM.librarianName = librarian.firstName + " " + librarian.lastName;
                    returnBookVM.bookId = returnedBook.bookId;
                    var book = db.Books.Where(b => b.id == returnedBook.bookId).Single();
                    returnBookVM.bookTitle = book.bookName;
                    returnBookVM.studentId = returnedBook.studentId;
                    var student = db.Students.Where(s => s.id == returnedBook.studentId).Single();
                    returnBookVM.studentName = student.name;
                    returnBookVM.DeliveryStatus = returnedBook.deliveryStatus;
                    returnBookVM.returnDate = returnedBook.returnDate;
                    returnBookVM.fine = returnedBook.fine;
                    result.allReturnedBooks.Add(returnBookVM);
                }
                result.isSuccess = true;
                result.message = "Data Retrieved Successfully.";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public float GetFineValueFromDB(int fineId)
        {
            var fineRecord = db.fines.Where(f => f.id == fineId).FirstOrDefault();
            return fineRecord.fine;
        }

        public BaseViewModel GetAllBooksFromDB()
        {
            try
            {
                return new BaseViewModel() { isSuccess = true, message = "Books Data Retreived Successfully.", data = db.Books.ToList() };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, data = null, message = ex.Message };
            }
        }
    }
}
