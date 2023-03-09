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
        List<Employee> employees = new List<Employee>();
        DataTable tableEmployees = new DataTable();

        public EmployeeService() 
        {
            employees.Add(new Employee("Tom", "Raweg", "14556985625", new DateTime(1973, 5, 16), "Employee", "tom.raweg@gmail.com", "tom.raweg@gmail.com", "+48 526 458 526", 'M'));
            employees.Add(new Employee("Anna", "Kotras", "75695485698", new DateTime(1981, 7, 4), "Employee", "anna.kotras@gmail.com", "anna.kotras@gmail.com", "+48 458 889 112", 'K'));
            employees.Add(new Employee("John", "Long", "75333345624", new DateTime(1988, 1, 20), "Employee", "john.long@gmail.com", "john.long@gmail.com", "+48 778 863 322", 'M'));
            employees.Add(new Employee("Mark", "Tompson", "25757133412", new DateTime(1979, 10, 11), "Doctor", "mark.tompson@gmail.com", "mark.tompson@gmail.com", "+48 775 552 122", 'M'));

            tableEmployees.Columns.Add("First name", typeof(string));
            tableEmployees.Columns.Add("Last name", typeof(string));
            //tableEmployees.Columns.Add("PESEL", typeof(string));
            //tableEmployees.Columns.Add("Date of birth", typeof(DateTime));
            tableEmployees.Columns.Add("Role", typeof(string));
            //tableEmployees.Columns.Add("Correspondence address", typeof(string));
            //tableEmployees.Columns.Add("E-mail address", typeof(string));
            //tableEmployees.Columns.Add("Phone number", typeof(string));
            //tableEmployees.Columns.Add("Sex", typeof(char));
            tableEmployees.Columns.Add("Is active", typeof(string));
        }

        public void UpdateEmployeeList()
        {

            // Here data should be taken from database
            // Temporarily we create data in constructor

            employees.Clear();
            tableEmployees.Clear();

            
        }


       public Employee ReturnCorrectEmployee(string? firstname, string? lastName, string? role)
        {
            foreach(Employee emp in employees)
            {
                if(emp.FirstName == firstname && emp.LastName == lastName && emp.Role == role)
                {
                    return emp;
                }
            }
            return null;
        }


        public DataTable GetEmployeeTable()
        {

            tableEmployees.Rows.Clear();

            // Changing data in tableEmployees

            /*foreach (Employee emp in employees)
            {
                tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.PESEL, emp.DateOfBirth, emp.Role, emp.CorrespondenceAddress, emp.Email, emp.PhoneNumber, emp.Sex, emp.IsActive ? "Active" : "Deactive");
            }
            return tableEmployees;*/



            foreach (Employee emp in employees)
            {
                tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.Role, emp.IsActive ? "Active" : "Deactive");

            }
            return tableEmployees;


        } 

        public List<Employee> GetEmployeeList()
        {
            return employees;
        }

        public int EmployeeListCount()
        {
            return employees.Count;
        }

        public DataTable FilterEmployee(string role, bool isActive)
        {
            tableEmployees.Rows.Clear();
            foreach (Employee emp in employees)
            {
                if (role != "none")
                {
                    if (emp.Role == role && emp.IsActive == isActive)
                        //tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.PESEL, emp.DateOfBirth, emp.Role, emp.CorrespondenceAddress, emp.Email, emp.PhoneNumber, emp.Sex, emp.IsActive ? "Active" : "Deactive");
                        tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.Role, emp.IsActive ? "Active" : "Deactive");
                }
                else
                {
                    if (emp.IsActive == isActive)
                        //tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.PESEL, emp.DateOfBirth, emp.Role, emp.CorrespondenceAddress, emp.Email, emp.PhoneNumber, emp.Sex, emp.IsActive ? "Active" : "Deactive");
                        tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.Role, emp.IsActive ? "Active" : "Deactive");
                }
            }

            return tableEmployees;
        }

        public void ActivateEmployee(Employee emp)
        {
            emp.IsActive = true;
        }

        public void DeactivateEmployee(Employee emp) { emp.IsActive = false; }


        //Validation upon addit Employee
        //Validate PESEL input
        public static (string, bool) validatePESEL(string input, DateTime selectedDate, int currentIndex)
        {
            string firstSix = input.Substring(0, 6);

            string formatedDate = selectedDate.ToString("dd/MM/yy");
            string rawDate = formatedDate.Replace("/", "");

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
