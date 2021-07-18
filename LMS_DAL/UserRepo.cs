using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;
using System.Drawing;

namespace LMS_DAL
{
    public class UserRepo
    {
        LMSDbContext db;
        public UserRepo()
        {
            db = new LMSDbContext();
        }

        public BaseViewModel saveUserInDB(User user)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                db.Users.Add(user);
                int success = db.SaveChanges();
                if (success != 0)
                {
                    result.message = "User Added Successfully.";
                    result.isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
                result.data = null;
            }
            return result;
        }

        public BaseViewModel isUserPresentInDB(string email)
        {
            BaseViewModel result = new BaseViewModel() ;
            try
            {
                var user = db.Users.Where(u => u.email == email).First();
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public UserRoleBaseVM getFilterUserFromDB(string searchText)
        {
            UserRoleBaseVM usersVM = new UserRoleBaseVM();
            try
            {
                var users = db.Users.Where(u => u.firstName.ToLower().Contains(searchText.ToLower()) || u.lastName.ToLower().Contains(searchText.ToLower()) || u.email.ToLower().Contains(searchText.ToLower())).ToList();
                usersVM.isSuccess = true;
                usersVM.users = new List<UserRoleVM>();
                foreach (var user in users)
                {
                    UserRoleVM userRoleVM = new UserRoleVM();
                    userRoleVM.id = user.id;
                    userRoleVM.firstName = user.firstName;
                    userRoleVM.lastName = user.lastName;
                    userRoleVM.email = user.email;
                    userRoleVM.password = user.password;
                    userRoleVM.profileImagePath = user.profileImagePath;
                    if (user.profileImagePath != null)
                    {
                        userRoleVM.profileImage = new Bitmap(user.profileImagePath);
                    }
                    else
                    {
                        userRoleVM.profileImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Images\\userDummyProfile.png");
                    }
                    userRoleVM.gender = user.gender;
                    userRoleVM.genderString = (user.gender == 1) ? "Male" : "Female";
                    userRoleVM.roleId = Convert.ToInt32(user.roleId);
                    var role = db.Roles.Where(r => r.id == user.roleId).FirstOrDefault();
                    userRoleVM.roleName = role.name;
                    usersVM.users.Add(userRoleVM);
                }
            }
            catch (Exception ex)
            {
                usersVM.isSuccess = false;
                usersVM.message = ex.Message;
            }
            return usersVM;
        }

        public BaseViewModel UpdateUserInDB(User usr)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var user = db.Users.Where(u => u.id == usr.id).FirstOrDefault();
                user.firstName = usr.firstName;
                user.lastName = usr.lastName;
                user.email = usr.email;
                user.password = usr.password;
                user.gender = usr.gender;
                user.profileImagePath = usr.profileImagePath;
                user.roleId = usr.roleId;
                int success = db.SaveChanges();
                if(success != 0)
                {
                    result.isSuccess = true;
                    result.message = "User Updated Successfully.";
                }
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public BaseViewModel DeleteUserFromDB(int user_id)
        {
            BaseViewModel result = new BaseViewModel();
            try
            {
                var user = db.Users.Where(u => u.id == user_id).FirstOrDefault();
                db.Users.Remove(user);
                int success = db.SaveChanges();
                if(success != 0)
                {
                    result.isSuccess = true;
                    result.message = "User Deleted Successfully.";
                }
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.message = ex.Message;
            }
            return result;
        }

        public UserRoleBaseVM getAllUsersFromDB()
        {
            UserRoleBaseVM usersVM = new UserRoleBaseVM();
            try
            {
                var users = db.Users.ToList();
                usersVM.isSuccess = true;
                usersVM.users = new List<UserRoleVM>();
                foreach (var user in users)
                {
                    UserRoleVM userRoleVM = new UserRoleVM();
                    userRoleVM.id = user.id;
                    userRoleVM.firstName = user.firstName;
                    userRoleVM.lastName = user.lastName;
                    userRoleVM.email = user.email;
                    userRoleVM.password = user.password;
                    userRoleVM.profileImagePath = user.profileImagePath;
                    if(user.profileImagePath != null)
                    {
                        userRoleVM.profileImage = new Bitmap(user.profileImagePath);
                    }
                    else
                    {
                        userRoleVM.profileImage = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Images\\userDummyProfile.png");
                    }
                    userRoleVM.gender = user.gender;
                    userRoleVM.genderString = (user.gender == 1) ? "Male" : "Female";
                    userRoleVM.roleId = Convert.ToInt32(user.roleId);
                    var role = db.Roles.Where(r => r.id == user.roleId).FirstOrDefault();
                    userRoleVM.roleName = role.name;
                    usersVM.users.Add(userRoleVM);
                }
            }
            catch (Exception ex)
            {
                usersVM.isSuccess = false;
                usersVM.message = ex.Message;
            }
            return usersVM;
        }

        public UserLoginVM getLoginUserFromDB(string email, string password)
        {
            UserLoginVM loginUser = new UserLoginVM();
            try
            {
                var user = db.Users.Where(u => (u.email == email && u.password == password)).FirstOrDefault();
                user.role = db.Roles.Where(r => r.id == user.roleId).First();
                loginUser.id = user.id;
                loginUser.loginUserFirstName = user.firstName;
                loginUser.loginUserLastName = user.lastName;
                loginUser.userRoleId = Convert.ToInt32(user.roleId);
                loginUser.roleName = user.role.name;
                loginUser.profileImagePath = user.profileImagePath;
                loginUser.isSuccess = true;
            }
            catch (Exception ex)
            {
                loginUser.message = ex.Message;
                loginUser.isSuccess = false;
            }
            return loginUser;
        }
    }
}
