using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<AppointmentModel> CheckAppointmentsAndReturnList(DateTime selectedDate, int idCalendar = 1)
        { 
            int idDay = selectedDate.Day;
            
            int idTerm = GetIdTerm(selectedDate.ToString("HH:mm"));
            List<AppointmentModel> appointments = new List<AppointmentModel>();

            using(AppDbContext context = new AppDbContext())
            {
                foreach(AppointmentModel appointment in context.DbAppointments)
                {
                    if(appointment.IdDay == idDay && appointment.IdCalendar == idCalendar)
                    {
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }
    }
}
