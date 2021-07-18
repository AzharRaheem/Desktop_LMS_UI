using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;

namespace LMS_DAL
{
    public class DashboardRepo
    {
        LMSDbContext db;
        public DashboardRepo()
        {
            db = new LMSDbContext();
        }

        public DashboardCounts getAllCountsFromDB()
        {
            DashboardCounts dashCounts = new DashboardCounts();
            try
            {
                dashCounts.isSuccess = true;
                dashCounts.rolesCount = db.Roles.Count();
                dashCounts.usersCount = db.Users.Count();
                dashCounts.booksCount = db.Books.Count();
                dashCounts.studentsCount = db.Students.Count();
            }
            catch (Exception ex)
            {
                dashCounts.message = ex.Message;
                dashCounts.isSuccess = false;
            }
            return dashCounts;
        }
    }
}
