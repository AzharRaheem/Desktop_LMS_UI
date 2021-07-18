using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;
using LMS_DAL;
using LMS_DomainModel;

namespace LMS_BLL
{
    public class BookBL
    {
        BookRepo bookRepo;
        public BookBL()
        {
            bookRepo = new BookRepo();
        }
        public BaseViewModel getAllCategories()
        {
            return bookRepo.getAllCategoriesFromDB();
        }

        public BaseViewModel SaveBook(Book book)
        {
            return bookRepo.SaveBookInDB(book);
        }

        public BookCategoryBaseVM getAllBooks()
        {
            return bookRepo.getAllBooksFromDB();
        }

        public BaseViewModel DeleteBook(int bookId)
        {
            return bookRepo.DeleteBookFromDB(bookId);
        }

        public BaseViewModel UpdateBook(Book book)
        {
            return bookRepo.UpdateBookInDB(book);
        }

        public BookCategoryBaseVM GetFilteredBooks(string search)
        {
            return bookRepo.GetFilteredRecordsFromDB(search);
        }
    }
}
