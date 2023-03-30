using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string? CorrespondenceAddress { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public EnumSex? Sex { get; set; }
        public EnumEmployeeRoles Role { get; set; }
        
        public bool IsActive { get; set; }

        [ForeignKey("UserModel")] public int IdUser { get; set; }
        public virtual UserModel UserModel { get; set; }
        [ForeignKey("SpecializationModel")] public int IdSpecialization { get; set; }
        public virtual SpecializationModel SpecializationModel { get; set; }


        public EmployeeModel() { }

        public EmployeeModel(string firstName, string lastName, string pesel, string dateOfBirth, string correspondenceAddress,
            string email, string phoneNumber, EnumSex sex, EnumEmployeeRoles role, int idSpecialization, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            PESEL = pesel;
            DateOfBirth = dateOfBirth;
            CorrespondenceAddress = correspondenceAddress;
            Email = email;
            PhoneNumber = phoneNumber;
            Sex = sex;
            Role = role;
            IdSpecialization = idSpecialization;
            IsActive = isActive;
        }

        public EmployeeModel(int idUser, string firstName, string lastName, string pesel, string dateOfBirth, string correspondenceAddress, 
            string email, string phoneNumber, EnumSex sex, EnumEmployeeRoles role, int idSpecialization, bool isActive)
        {
            IdUser = idUser;
            FirstName = firstName;
            LastName = lastName;
            PESEL = pesel;
            DateOfBirth = dateOfBirth;
            CorrespondenceAddress = correspondenceAddress;
            Email = email;
            PhoneNumber = phoneNumber;
            Sex = sex;
            Role = role;
            IdSpecialization = idSpecialization;
            IsActive = isActive;
        }


        
        public static void ChangeEmployeeStatus(EmployeeModel employee)
        {
            if (employee.IsActive == true)
            {
                var context = new AppDbContext();
                employee = context.DbEmployees.Find(employee.IdEmployee);
                employee.IsActive = false;
                context.SaveChanges();
                return;
            }
            else if (employee.IsActive == false)
            {
                var context = new AppDbContext();

                EmployeeModel emp = context.DbEmployees.Find(employee.IdEmployee); // for remove

                emp.IsActive = true;
                context.SaveChanges();
                return;
            }
        }
        

        
        public static EmployeeModel FindEmployee(int IdEmployee)
        {
            EmployeeModel emp = new EmployeeModel();
            var context = new AppDbContext();
            emp = context.DbEmployees.Find(IdEmployee);

            return emp;
        }

        public static List<EmployeeModel> FilterEmployees(EnumEmployeeRoles role, bool isActive)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (EmployeeModel employee in EmployeeService.GetEmployeesData())
            {
                if(employee.Role==role && employee.IsActive == isActive)
                {
                    employees.Add(employee);
                }
            }

            return employees;
        }
        

        public static void EditEmployee(int IdEmployee, /*int idUser*/ string firstName, string lastName, string pesel, string dateOfBirth, EnumEmployeeRoles rolem, string correspondenceAddress, string email, string phoneNumber,
            EnumSex sex)
        {
            var context = new AppDbContext();
            var emp = context.DbEmployees.Find(IdEmployee);
            //emp.IdUser = idUser;
            emp.FirstName = firstName;
            emp.LastName = lastName;
            emp.PESEL = pesel;
            emp.DateOfBirth = dateOfBirth;
            emp.CorrespondenceAddress = correspondenceAddress;
            emp.Email = email;
            emp.PhoneNumber = phoneNumber;
            emp.Sex = sex;
            context.SaveChanges();
        }

    }
}
