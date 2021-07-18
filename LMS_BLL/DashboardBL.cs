using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel.ViewModels;
using LMS_DAL;

namespace LMS_BLL
{
    public class DashboardBL
    {
        DashboardRepo dashboardRepo;
        public DashboardBL()
        {
            dashboardRepo = new DashboardRepo();
        }

        public DashboardCounts getAllCounts()
        {
            return dashboardRepo.getAllCountsFromDB();
        }
    }
}
