using LMS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;

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
    }
}
