<<<<<<< HEAD
﻿using Console_Management_of_medical_clinic.Data.Enums;
using System;
=======
﻿using System;
>>>>>>> 031ebc01d1ca502c76f533b8908d4fbc57959a55
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class UserModel
    {
        [Key] public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public EnumUserRoles Role { get; set; }



        public bool IsActive { get; set; }

        public UserModel() { }


        public UserModel(string username, string password, EnumUserRoles role, bool isActive)



        {
            Username = username;
            Password = password;
            Role = role;
            IsActive = isActive;
        }
    }




}
