using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
