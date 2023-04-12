using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static void AddUser(int userID, string username, string password, EnumUserRoles role, bool isActive, int employeeId)
        {
            //a method to add new User and to change the value of IdUser pole of the selected Employee 
            using(AppDbContext db = new AppDbContext())
            {
                db.DbUsers.Add(new UserModel(username, password, role, isActive));
                db.SaveChanges();
            }
            //not ready
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
                //filteredUsers = filteredUsers.Where(u => u.FirstName.Contains(firstname)).ToList();
            }

            if (!string.IsNullOrEmpty(lastname))
            {
                //filteredUsers = filteredUsers.Where(u => u.LastName.Contains(lastname)).ToList();
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
    }
        
}
