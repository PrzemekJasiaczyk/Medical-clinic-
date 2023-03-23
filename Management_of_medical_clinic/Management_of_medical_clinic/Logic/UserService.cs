using Console_Management_of_medical_clinic.Data;
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
