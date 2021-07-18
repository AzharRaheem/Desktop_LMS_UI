using LMS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;

namespace LMS_BLL
{
    public class UserBL
    {
        UserRepo userRepo;
        public UserBL()
        {
            userRepo = new UserRepo();
        }

        public BaseViewModel saveUser(User user)
        {
            if(user.roleId == null)
            {
                user.roleId = 2;
            }
            user.password = Hash.Hash_SHA1(user.password);
            return userRepo.saveUserInDB(user);
        }

        public UserLoginVM getLoginUser(string email, string password)
        {
            return userRepo.getLoginUserFromDB(email, Hash.Hash_SHA1(password));
        }

        public UserRoleBaseVM getAllUsers()
        {
            return userRepo.getAllUsersFromDB();
        }

        public BaseViewModel isUserPresent(string email)
        {
            return userRepo.isUserPresentInDB(email);
        }

        public BaseViewModel DeleteUser(int user_id)
        {
            return userRepo.DeleteUserFromDB(user_id);
        }

        public BaseViewModel UpdateUser(User user)
        {
            return userRepo.UpdateUserInDB(user);
        }

        public UserRoleBaseVM getFilterUser(string searchText)
        {
         return userRepo.getFilterUserFromDB(searchText);
        }
    }
}
