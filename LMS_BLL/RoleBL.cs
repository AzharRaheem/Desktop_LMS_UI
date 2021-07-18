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
    public class RoleBL
    {
        RoleRepo roleRepo;
        public RoleBL()
        {
            roleRepo = new RoleRepo();
        }

        public BaseViewModel saveRole(Role role)
        {
            return roleRepo.saveRoleInDB(role);
        }

        public BaseViewModel getAllRoles()
        {
            return roleRepo.getAllRolesFromDB();
        }

        public BaseViewModel deleteRole(int id)
        {
            return roleRepo.deleteRoleFromDB(id);
        }

        public BaseViewModel updateRole(Role role)
        {
            return roleRepo.updateRoleInDB(role);
        }

        public BaseViewModel getFilteredRecords(string search)
        {
            return roleRepo.getFilteredRecordsFromDB(search);
        }
    }
}
