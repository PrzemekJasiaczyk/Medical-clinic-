using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class EmployeeService
    {
        public static void AddEmployee(int idUser, string firstName, string lastName, string pesel, string dateOfBirth,  string correspondenceAddress, string email, string phoneNumber,
            EnumSex sex, string username, string password, EnumEmployeeRoles role, SpecializationModel idSpecialization, bool isActive)
        {

            EmployeeModel employee = new EmployeeModel(idUser, firstName, lastName, pesel, dateOfBirth, correspondenceAddress, email, phoneNumber,
            sex, role, idSpecialization, isActive);

            using AppDbContext context = new AppDbContext();

            context.DbEmployees.Add(employee);
            context.SaveChanges();
        }

        public static List<EmployeeModel> GetEmployeesData()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            using (var db = new AppDbContext())
            {
                employees = db.DbEmployees.ToList();
            }


            foreach (var employee in employees)
            {
                string test2 = employee.LastName;
                int test = employee.IdUser;
            }

            return employees;
        }

        public static EmployeeModel GetEmployeeByUserId(UserModel user)
        {
            List<EmployeeModel> employees = GetEmployeesData();

            foreach(EmployeeModel employee in employees)
            {
                if (employee.IdUser == user.IdUser)
                {
                    return employee;
                }
            }
            return null;
        }


        /*    
        
        public static bool CheckIfUsernameExists(string username)
        {
            List<EmployeeModel> employees = EmployeeService.GetEmployeesData();


            foreach (EmployeeModel employee in employees)
            {
                if (employee.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        */

        



        //Validation upon addit Employee
        //Validate PESEL input
        public static (string, bool) validatePESEL(string input, DateTime selectedDate, int currentIndex)
        {
            string firstSix = input.Substring(0, 6);

            string formatedDate = selectedDate.ToString("dd/MM/yy");
            string rawDate = formatedDate.Replace(".", "");
            rawDate = rawDate.Replace("/", "");

            if (input.Length != 11)
            {
                return ("PESEL should be 11 digits long", false);

            }

            if (!long.TryParse(input, out long result))
            {
                return ("PESEL can only contain digits", false);
            }

            if (firstSix != rawDate)
            {
                return ("PESEL doesn't fit the date of birth", false);
            }

            if (currentIndex == 1 && input.Substring(input.Length - 2, 1)[0] % 2 == 0)
            {
                return ("PESEL doesn't fit the sex", false);
            }

            if (currentIndex == 2 && input.Substring(input.Length - 2, 1)[0] % 2 == 1)
            {
                return ("PESEL doesn't fit the sex", false);
            }


            return ("Success",true);
        }

        //Validate Email input
        public static (string, bool) validateEmail(string input, string name)
        {
            int atIndex = input.IndexOf('@');
            int dotIndex = input.LastIndexOf('.');
            List<string> domainList = new List<string> { ".com", ".org", ".net" };


            if (input.Length > 0)
            {
                if (input.Count(c => c == '@') != 1)
                {
                    return ("E-mail has to contain one '@' sign", false);
                }

                if (!input.Contains("."))
                {
                    return ("E-mail has to contain at least one '.' sign", false);
                }


                if (atIndex < 1 || atIndex == input.Length - 1)
                {
                    return ("The '@' sign has to have characers in front and behind of it", false);
                }


                if (dotIndex < atIndex + 2 || dotIndex == input.Length - 1)
                {
                    return ("The last '.' sign has to have characters behind and after it,\nand it has to be after the '@' sign", false);
                }

                if (!input.Contains(name))
                {
                    return ("E-mail needs to contain the recipient's name", false);
                }

                foreach(string domain in domainList)
                {
                    if (input.EndsWith(domain))
                    {
                        break;
                    }
                    return ("E-mail needs to contain a valid top-level domain", false);
                }
            }

            return ("Success", true);
        }

        //Validate Phone Number input
        public static (string, bool) validatePhone(string input)
        {
            if (input.Length > 0)
            {
                if (input.Length != 9)
                {
                    return ("Phone number has to be 9 digits long", false);
                }

                if (!long.TryParse(input, out long result))
                {
                    return ("Phone number can only contain digits", false);
                }
            }
            return ("Success", true);
        }
    }

}
