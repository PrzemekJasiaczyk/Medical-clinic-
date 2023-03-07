using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public char Sex { get; set; }
        public bool IsActive { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, string pesel, DateTime dateOfBirth, string role, string correspondenceAddress, string email, string phoneNumber, char sex)
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
            IsActive = true;
        }
    }
}
