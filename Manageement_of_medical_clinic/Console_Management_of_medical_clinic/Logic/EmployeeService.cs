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
            tableEmployees.Columns.Add("PESEL", typeof(string));
            tableEmployees.Columns.Add("Date of birth", typeof(DateTime));
            tableEmployees.Columns.Add("Role", typeof(string));
            tableEmployees.Columns.Add("Correspondence address", typeof(string));
            tableEmployees.Columns.Add("E-mail address", typeof(string));
            tableEmployees.Columns.Add("Phone number", typeof(string));
            tableEmployees.Columns.Add("Sex", typeof(char));
        }

        public DataTable GetEmployeeTable()
        {
            tableEmployees.Rows.Clear();
            foreach (Employee emp in employees)
            {
                tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.PESEL, emp.DateOfBirth, emp.Role, emp.CorrespondenceAddress, emp.Email, emp.PhoneNumber, emp.Sex);
            }
            return tableEmployees;
        } 

        public DataTable FilterEmployee(string role, bool isActive)
        {
            tableEmployees.Rows.Clear();
            foreach (Employee emp in employees)
            {
                if (role != "none")
                {
                    if (emp.Role == role && emp.IsActive == isActive)
                        tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.PESEL, emp.DateOfBirth, emp.Role, emp.CorrespondenceAddress, emp.Email, emp.PhoneNumber, emp.Sex);
                }
                else
                {
                    if (emp.IsActive == isActive)
                        tableEmployees.Rows.Add(emp.FirstName, emp.LastName, emp.PESEL, emp.DateOfBirth, emp.Role, emp.CorrespondenceAddress, emp.Email, emp.PhoneNumber, emp.Sex);
                }
            }

            return tableEmployees;
        }
    }
}
