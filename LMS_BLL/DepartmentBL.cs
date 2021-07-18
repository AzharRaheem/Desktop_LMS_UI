using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;
using LMS_DAL;

namespace LMS_BLL
{
    public class DepartmentBL
    {
        DepartmentRepo departmentRepo;
        public DepartmentBL()
        {
            departmentRepo = new DepartmentRepo();
        }
        public BaseViewModel SaveDepartment(Department department)
        {
            return departmentRepo.SaveDepartmentInDB(department);
        }

        public BaseViewModel GetAllDepartments()
        {
            return departmentRepo.GetAllDepartmentsFromDB();
        }

        public BaseViewModel DeleteDepartment(int deptId)
        {
            return departmentRepo.DeleteDepartmentFromDB(deptId);
        }

        public BaseViewModel UpdateDepartment(Department department)
        {
            return departmentRepo.UpdateDepartmentInDB(department);
        }
    }
}
