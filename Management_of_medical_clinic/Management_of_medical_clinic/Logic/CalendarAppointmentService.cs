using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class CalendarAppointmentService: AppointmentModel
    {
                


        public static Patient GetPatientDataByIdPatient(AppointmentModel appointment)
        {
            Patient result = new Patient();

            if (appointment.PatientId == null)
            {
                throw new Exception("IdEmployee = null");
            }

            using (AppDbContext context = new AppDbContext())
            {
                foreach (Patient patient in context.Patients)
                {
                    if (patient.PatientId == appointment.PatientId)
                    {
                        result = patient;
                    }
                }
            }

            if (result == null)
            {
                throw new Exception("Patient not found in database");
            }

            return result;

        }

        public static List<AppointmentModel> GetFreeAppointments()
        {
            List<AppointmentModel> appointments = GetAppointmentsData();
            List <AppointmentModel> result = new List<AppointmentModel>();

            foreach (AppointmentModel appointment in appointments)
            {
                if (appointment.PatientId != null && appointment.IsActive == true)
                {
                    result.Add(appointment);
                }
            }

            return result;
        }

        public static string GetLastNameAndNameOfEmployeeByAppointment(AppointmentModel AppointmentModel)
        {
            if (AppointmentModel.IdEmployee == null)
            {
                throw new Exception("IdEmployee = null");
            }

            string result = string.Empty;


            int id = (int)AppointmentModel.IdEmployee;

            using (AppDbContext context = new AppDbContext())
            {
                foreach (EmployeeModel employeeModel in context.DbEmployees)
                {
                    if (employeeModel.IdEmployee == id)
                    {
                        result = employeeModel.FirstName + " " + employeeModel.LastName;
                    }
                }
            }

            if (result == string.Empty)
            {
                throw new Exception("Employee not found in database");
            }

            return result;

        }

        public static List<AppointmentModel> GetAppointmentsData()
        {
            List<AppointmentModel> result = new List<AppointmentModel>();

            using (AppDbContext context = new AppDbContext())
            {
                result = context.DbAppointments
                    .Select(a => new AppointmentModel
                    {
                        IdAppointment = a.IdAppointment,
                        IdTerm = a.IdTerm,
                        Cost = a.Cost,
                        IsActive = a.IsActive,
                        IdCalendar = a.IdCalendar,
                        IdEmployee = a.IdEmployee,
                        PatientId = a.PatientId ?? null,
                        IdOffice = a.IdOffice,
                        IdDay = a.IdDay
                    })
                    .ToList();
            }
            return result;
        }


        public static List<AppointmentModel> appointmentInSelectedDate(List<AppointmentModel> ListIn, DateTime selectedDate, int idCalendar)
        {
            List<AppointmentModel> result = new List<AppointmentModel>();

            int idDay = selectedDate.Day;

            foreach (AppointmentModel appointment in ListIn)
            {
                if (appointment.IdCalendar == idCalendar && appointment.IdDay == idDay)
                {
                    result.Add(appointment);
                }
            }
            return result;
        }






    }
}
