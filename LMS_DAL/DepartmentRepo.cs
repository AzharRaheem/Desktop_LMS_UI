using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;

namespace LMS_DAL
{
    public class DepartmentRepo
    {
        LMSDbContext db;
        public DepartmentRepo()
        {
            db = new LMSDbContext();
        }
        public BaseViewModel SaveDepartmentInDB(Department department)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                db.Departments.Add(department);
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Department Added Successfully.";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel DeleteDepartmentFromDB(int deptId)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var department = db.Departments.Where(d => d.id == deptId).FirstOrDefault();
                db.Departments.Remove(department);
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Department Deleted Successfully.";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel UpdateDepartmentInDB(Department department)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var record = db.Departments.Where(d => d.id == department.id).FirstOrDefault();
                record.id = department.id;
                record.name = department.name;
                db.SaveChanges();
                result.isSuccess = true;
                result.message = "Department Updated Successfully.";
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel GetAllDepartmentsFromDB()
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                result.data = db.Departments.ToList();
                result.isSuccess = true;
            }
            catch(Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
                result.data = null;
            }
            return result;
        }
    }
}
