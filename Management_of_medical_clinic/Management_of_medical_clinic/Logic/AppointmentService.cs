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
                string selectedDay = (dateParts[0]);
                string selectedTerm = (dateParts[1]);
                int id = GetDayIdByDate2(selectedDate);

                int term = AppointmentService.GetIdTerm(selectedTerm);
                int idAppointment = (int)db.DbAppointments
                    .Where(e => e.IdDay == id && e.IdTerm == term)
                    .Select(e => e.IdAppointment)
                    .FirstOrDefault();
                return idAppointment;
            }

        }

        public static int GetDayIdByDate2(string selectedTerm)
        {
            List<CalendarModel> calendars =CalendarService.GetCalendarData();

            foreach (CalendarModel calendar in calendars)
            {
                DateTime referenceDate = DateTime.ParseExact(calendar.DateReference, "MM-yyyy", CultureInfo.InvariantCulture);

                if (DateTime.ParseExact(selectedTerm, "yyyy-MM-dd", CultureInfo.InvariantCulture).Year == referenceDate.Year
                    && DateTime.ParseExact(selectedTerm, "yyyy-MM-dd", CultureInfo.InvariantCulture).Month == referenceDate.Month)
                {
                    int daysInMonth = DateTime.DaysInMonth(referenceDate.Year, referenceDate.Month);
                    int dayOfMonth = DateTime.ParseExact(selectedTerm, "yyyy-MM-dd", CultureInfo.InvariantCulture).Day;

                    return calendar.IdCalendar + dayOfMonth - 1;
                }
            }

            throw new ArgumentException("Invalid date or calendar ID");
        }
    }
}
