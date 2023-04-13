
﻿using Console_Management_of_medical_clinic.Data.Enums;
using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        //Relationships
        [ForeignKey("EmployeeModel")] public int IdEmployee { get; set; }
        public EmployeeModel EmployeeModel { get; set; }


        public UserModel(string username, string password, EnumUserRoles role, bool isActive, int idEmployee) {
            Username = username;
            Password = password;
            Role = role;
            IsActive = isActive;
            IdEmployee = idEmployee;
        }

        public UserModel(string username, string password, EnumUserRoles role, bool isActive)

        {
            Username = username;
            Password = password;
            Role = role;
            IsActive = isActive;
        }

        public UserModel(int idUser, string username, string password, EnumUserRoles role, bool isActive)

        {
            IdUser = idUser;
            Username = username;
            Password = password;
            Role = role;
            IsActive = isActive;
        }
    }




}
