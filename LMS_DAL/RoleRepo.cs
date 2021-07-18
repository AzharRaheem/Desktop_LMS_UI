using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;
using System.Data.Entity;

namespace LMS_DAL
{
    public class RoleRepo
    {
        LMSDbContext db;
        public RoleRepo()
        {
            db = new LMSDbContext();
        }
        public BaseViewModel saveRoleInDB(Role role)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                db.Roles.Add(role);
                int success = db.SaveChanges();
                if (success != 0)
                {
                    result.isSuccess = true;
                    result.message = "Role Added Successfully.";
                    result.data = null;
                }
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.data = null;
                result.isSuccess = false;
            }
            return result;
        }

        public BaseViewModel getFilteredRecordsFromDB(string search)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                result.isSuccess = true;
                result.data = db.Roles.Where(r => r.name.ToLower().Contains(search.ToLower())).ToList();
                result.message = null;
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.data = null;
                result.isSuccess = false;
            }
            return result;
        }

        public BaseViewModel updateRoleInDB(Role role)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var rol = db.Roles.Where(r => r.id == role.id).First();
                rol.name = role.name;
                int success = db.SaveChanges();
                if(success != 0)
                {
                    result.message = "Role Updated Successfully.";
                    result.isSuccess = true;
                    result.data = null;
                }
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.data = null;
                result.isSuccess = false;
            }
            return result;
        }

        public BaseViewModel deleteRoleFromDB(int id)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var role = db.Roles.Where(r => r.id == id).First();
                db.Roles.Remove(role);
                int success = db.SaveChanges();
                if(success != 0)
                {
                    result.message = "Role Deleted Successfully.";
                    result.data = null;
                    result.isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.data = null;
                result.isSuccess = false;
            }
            return result;
        }

        public BaseViewModel getAllRolesFromDB()
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                result.isSuccess = true;
                result.data = db.Roles.ToList();
                result.message = null;
            }
            catch (Exception ex)
            {
                result.message = ex.Message;
                result.data = null;
                result.isSuccess = false;
            }
            return result;
        }
    }
}
