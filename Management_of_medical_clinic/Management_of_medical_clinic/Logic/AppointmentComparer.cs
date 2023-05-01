using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class AppointmentComparer : IComparer<AppointmentModel>
    {
        public int Compare(AppointmentModel x, AppointmentModel y)
        {
            // pobierz nazwisko lekarza dla obiektów x i y
            string lastNameX = EmployeeService.GetEmployeeByID((int)x.IdEmployee).LastName;
            string lastNameY = EmployeeService.GetEmployeeByID((int)y.IdEmployee).LastName;

            // porównaj nazwiska lekarzy
            return lastNameX.CompareTo(lastNameY);
        }
    }
}
