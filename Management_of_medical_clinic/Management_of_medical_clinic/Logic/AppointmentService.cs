using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class AppointmentService
    {
        public static void AddAppointment(AppointmentModel appointmentModel)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.DbAppointments.Add(appointmentModel);
                context.SaveChanges();
            }
        }

        public static int GetIdTerm(string selectedTime)
        {

            string[] timeParts = selectedTime.Split(':');
            int hour = int.Parse(timeParts[0]);
            int minute = int.Parse(timeParts[1]);
            int selectedTimeInMinutes = (hour * 60) + minute;


            if (selectedTimeInMinutes < 420 || selectedTimeInMinutes >= 1200 || (selectedTimeInMinutes >= 660 && selectedTimeInMinutes < 680) || (selectedTimeInMinutes >= 980 && selectedTimeInMinutes < 1000))
            {

                return -1;
            }
            else
            {
                int idTerm = ((selectedTimeInMinutes - 420) / 20) + 1;
                return idTerm;
            }
        }

        public static string GetTermByTermId(int idTerm)
        {
            int minutesFromOpening = (idTerm - 1) * 20;
            int hour = minutesFromOpening / 60 + 7;
            int minute = minutesFromOpening % 60;
            return $"{hour:00}:{minute:00}";
        }

        public static Patient GetPatientDataByIdPatient(AppointmentModel appointment)
        {
            Patient result = new Patient();

            if (appointment.PatientId == null)
            {
                throw new Exception("IdEmployee = null");
            }

            using(AppDbContext context =  new AppDbContext()) 
            {
                foreach(Patient patient in  context.Patients) 
                {
                    if(patient.PatientId == appointment.PatientId)
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

        public static string GetLastNameAndNameOfEmployeeByAppointment(AppointmentModel AppointmentModel)
        {
            if (AppointmentModel.IdEmployee == null) 
            { 
                throw new Exception ("IdEmployee = null");
            }

            string result = string.Empty;


            int id = (int)AppointmentModel.IdEmployee;

            using (AppDbContext context = new AppDbContext())
            {
                foreach(EmployeeModel employeeModel in context.DbEmployees)
                {
                    if(employeeModel.IdEmployee == id)
                    {
                       result = employeeModel.FirstName+" "+ employeeModel.LastName;
                    }
                }
            }
            
            if(result==string.Empty)
            {
                throw new Exception("Employee not found in database");
            }

            return result;

        }

        public static List<AppointmentModel> GetAppointmentData()
        {
            List<AppointmentModel> result = new List<AppointmentModel> ();

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
                        PatientId = a.PatientId ?? 0,
                        IdOffice = a.IdOffice,
                        IdDay = a.IdDay 
                    })
                    .ToList();
            }
            return result;
        }


        public static List<AppointmentModel> CheckAppointmentsAndReturnList(DateTime selectedDate, int idCalendar = 1)
        { 
            int idDay = selectedDate.Day;
            
            int idTerm = GetIdTerm(selectedDate.ToString("HH:mm"));
            List<AppointmentModel> appointments = new List<AppointmentModel>();

            using(AppDbContext context = new AppDbContext())
            {
                foreach (AppointmentModel appointment in context.DbAppointments)
                {
                    if (appointment.IdDay == idDay && appointment.IdCalendar == idCalendar)
                    {
                        appointments.Add(appointment);
                    }
                }
            }
            return appointments;
        }

        public static int GetAppointmentId(string selectedDate)
        {

            using (AppDbContext db = new AppDbContext())
            {
                string[] dateParts = selectedDate.Split(' ');
                int selectedDay = int.Parse(dateParts[0]);
                string selectedTerm = (dateParts[1]);


                int term = AppointmentService.GetIdTerm(selectedTerm);
                int idAppointment = (int)db.DbAppointments
                    .Where(e => e.IdDay == selectedDay && e.IdTerm == term)
                    .Select(e => e.IdAppointment)
                    .FirstOrDefault();
                return idAppointment;
            }

        }
    }
}
