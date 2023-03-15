using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class EmployeeModel
    {
        [Key] public int IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
        public string DateOfBirth { get; set; }
        public string Role { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public EnumSex Sex { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public SpecializationModel IdSpecialization { get; set; }
        public bool IsActive { get; set; }

        public EmployeeModel() { }

        public EmployeeModel(int idEmployee, string firstName, string lastName, string pesel, string dateOfBirth, string role, string correspondenceAddress, string email, string phoneNumber, 
            EnumSex sex, string username, string password, SpecializationModel idSpecialization, bool isActive)
        {
            IdEmployee = idEmployee;
            FirstName = firstName;
            LastName = lastName;
            PESEL = pesel;
            DateOfBirth = dateOfBirth;
            Role = role;
            CorrespondenceAddress = correspondenceAddress;
            Email = email;
            PhoneNumber = phoneNumber;
            Sex = sex;
            Username = username;
            Password = password;
            IdSpecialization = idSpecialization;
            IsActive = isActive;
        }

        public EmployeeModel(string firstName, string lastName, string pesel, string dateOfBirth, string role, string correspondenceAddress, string email, string phoneNumber,
            EnumSex sex, string username, string password, SpecializationModel idSpecialization, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            PESEL = pesel;
            DateOfBirth = dateOfBirth;
            Role = role;
            CorrespondenceAddress = correspondenceAddress;
            Email = email;
            PhoneNumber = phoneNumber;
            Sex = sex;
            Username = username;
            Password = password;
            IdSpecialization = idSpecialization;
            IsActive = isActive;
        }

        public void ChangeEmployeeStatus(EmployeeModel employee)
        {
            if (employee.IsActive == true)
            {
                var context = new AppDbContext();
                var emp = context.DbEmployees.Find(employee.IdEmployee);
                emp.IsActive = false;
                context.SaveChanges();
            }

            if (employee.IsActive == false)
            {
                var context = new AppDbContext();
                var emp = context.DbEmployees.Find(employee.IdEmployee);
                emp.IsActive = true;
                context.SaveChanges();
            }



        }
    }
}
