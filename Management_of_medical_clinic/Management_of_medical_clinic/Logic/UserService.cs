using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class UserService
    {
        public static List<UserModel> GetUsersData()
        {
            List<UserModel> users = new List<UserModel>();
            using (var db = new AppDbContext())
            {
                users = db.DbUsers.ToList();
            }

            return users;
        }

        public static void AddUser(string username, string password, EnumUserRoles role, bool isActive, int employeeId)
        {
            //a method to add new User to Database
            using(AppDbContext db = new AppDbContext())
            {
                db.DbUsers.Add(new UserModel(username, password, role, isActive, employeeId));
                db.SaveChanges();
            }
        } 

        public static List<UserModel> FilterUsers(string username, string firstname, string lastname, string role)
        {

            List<UserModel> filteredUsers = GetUsersData();

            if (!string.IsNullOrEmpty(username))
            {
                filteredUsers = filteredUsers.Where(u => u.Username.Contains(username)).ToList();
            }

            if (!string.IsNullOrEmpty(firstname))
            {
                filteredUsers = filteredUsers.Where(u => EmployeeModel.FindEmployee(u.IdEmployee).FirstName.Contains(firstname)).ToList();
            }

            if (!string.IsNullOrEmpty(lastname))
            {
                filteredUsers = filteredUsers.Where(u => EmployeeModel.FindEmployee(u.IdEmployee).LastName.Contains(lastname)).ToList();
            }

            if (role != "")
            {
                EnumUserRoles roleUser = (EnumUserRoles)Enum.Parse(typeof(EnumUserRoles), role);
                filteredUsers = filteredUsers.Where(u => u.Role == roleUser).ToList();
            }

            return filteredUsers;
        }

        public static UserModel GetUserById(int id)
        {
            return GetUsersData().FirstOrDefault(u => u.IdUser == id);
        }

        public static bool CheckIfUsernameExists(string username)
        {
            List<UserModel> users = UserService.GetUsersData();


            foreach (UserModel user in users)
            {
                if (user.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckIfIdIsAlreadyUsed(int id)
        {
            return GetUsersData().Any(u => u.IdEmployee == id);
        }

        public static void EditUser(int idUser, string username, EnumUserRoles userRoles, bool isActive, int idEmployee)
        {
            using (AppDbContext db = new AppDbContext()) {
                UserModel user = db.DbUsers.Find(idUser);
                if (user != null)
                {
                    user.Username = username;
                    user.Role = userRoles;
                    user.IsActive = isActive;
                    user.IdEmployee = idEmployee;
                    db.SaveChanges();
                }
            }
        }

        public static bool ValidatePassword(string password)
        {
            return Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[-_!#$*]).{8,15}$").Success;
        }

        public static void ChangePassword(int idUser, string password)
        {
            using(AppDbContext db = new AppDbContext())
            {
                UserModel user = db.DbUsers.Find(idUser);
                if (user != null)
                {
                    user.Password = password;
                    db.SaveChanges();
                }
            }
        }

        public static UserModel GetUserByEmployeeId(EmployeeModel employee)
        {
            List<UserModel> users = GetUsersData();
            foreach(UserModel user in users)
            {
                if(employee.IdEmployee == user.IdEmployee)
                {
                    return user;
                }
            }
            return null;
        }
    }
        
}
