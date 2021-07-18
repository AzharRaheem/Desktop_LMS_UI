using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;
using System.Drawing;

namespace LMS_DAL
{
    public class BookRepo
    {
        LMSDbContext db;
        public BookRepo()
        {
            db = new LMSDbContext();
        }
        public BaseViewModel getAllCategoriesFromDB()
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var categories = db.Categories.ToList();
                result.isSuccess = true;
                result.data = categories;
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
            }
            return result;
        }

        public BaseViewModel DeleteBookFromDB(int bookId)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var book = db.Books.Where(b => b.id == bookId).FirstOrDefault();
                db.Books.Remove(book);
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Book Deleted Successfully.";
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
            }
            return result;
        }

        public BookCategoryBaseVM GetFilteredRecordsFromDB(string search)
        {
            BookCategoryBaseVM result = new BookCategoryBaseVM();
            try
            {
                var allBooks = db.Books.Where(b => b.bookName.ToLower().Contains(search.ToLower()) || b.authorName.ToLower().Contains(search.ToLower()) || b.publisherName.ToLower().Contains(search.ToLower()) || b.barcode.ToLower().Contains(search.ToLower()) || b.bookEdition.ToLower().Contains(search.ToLower())).ToList();
                result.books = new List<BookCategoryVM>();
                foreach (var book in allBooks)
                {
                    BookCategoryVM bookCategoryVM = new BookCategoryVM();
                    bookCategoryVM.id = book.id;
                    bookCategoryVM.bookImagePath = book.bookImagePath;
                    if (book.bookImagePath != null)
                    {
                        bookCategoryVM.bookImage = new Bitmap(book.bookImagePath);
                    }
                    else
                    {
                        bookCategoryVM.bookImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Images\\bookDummy.png");
                    }
                    bookCategoryVM.bookTitle = book.bookName;
                    bookCategoryVM.categoryId = book.categoryid;
                    bookCategoryVM.category = book.category.name;
                    bookCategoryVM.authorName = book.authorName;
                    bookCategoryVM.publisher = book.publisherName;
                    bookCategoryVM.bookEdition = book.bookEdition;
                    bookCategoryVM.barcode = book.barcode;
                    bookCategoryVM.price = book.price;
                    bookCategoryVM.bookISBN = book.book_ISBN;
                    result.books.Add(bookCategoryVM);
                }
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
            }
            return result;
        }

        public BaseViewModel UpdateBookInDB(Book book)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var record = db.Books.Where(b => b.id == book.id).FirstOrDefault();
                record.id = book.id;
                record.bookName = book.bookName;
                record.categoryid = book.categoryid;
                record.authorName = book.authorName;
                record.publisherName = book.publisherName;
                record.bookEdition = book.bookEdition;
                record.price = book.price;
                record.barcode = book.barcode;
                record.book_ISBN = book.book_ISBN;
                record.bookImagePath = book.bookImagePath;
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Book Updated Successfully.";
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
            }
            return result;
        }

        public BookCategoryBaseVM getAllBooksFromDB()
        {
            BookCategoryBaseVM result = new BookCategoryBaseVM();
            try
            {
                var allBooks = db.Books.ToList();
                result.books = new List<BookCategoryVM>();
                foreach (var book in allBooks)
                {
                    BookCategoryVM bookCategoryVM = new BookCategoryVM();
                    bookCategoryVM.id = book.id;
                    bookCategoryVM.bookImagePath = book.bookImagePath;
                    if (book.bookImagePath != null)
                    {
                        bookCategoryVM.bookImage = new Bitmap(book.bookImagePath);
                    }
                    else
                    {
                        bookCategoryVM.bookImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Images\\bookDummy.png");
                    }
                    bookCategoryVM.bookTitle = book.bookName;
                    bookCategoryVM.categoryId = book.categoryid;
                    bookCategoryVM.category = book.category.name;
                    bookCategoryVM.authorName = book.authorName;
                    bookCategoryVM.publisher = book.publisherName;
                    bookCategoryVM.bookEdition = book.bookEdition;
                    bookCategoryVM.barcode = book.barcode;
                    bookCategoryVM.price = book.price;
                    bookCategoryVM.bookISBN = book.book_ISBN;
                    result.books.Add(bookCategoryVM);
                }
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.isSuccess = false;
            }
            return result;
        }

        public BaseViewModel SaveBookInDB(Book book)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                db.Books.Add(book);
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Book Added Successfully.";
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
