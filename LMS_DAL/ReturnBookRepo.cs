using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;

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
