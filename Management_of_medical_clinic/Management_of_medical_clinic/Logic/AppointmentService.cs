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
        public static void DoctorModifiesAppointment(int idappointment, int office, int term, int day)
        {
            var context = new AppDbContext();
            var appontment = context.DbAppointments.Find(idappointment);

            appontment.IdTerm = term;
            appontment.IdOffice = office;
            appontment.IdDay = day;

            context.SaveChanges();
        }

        // Validation when rescheduling
        public (bool, string) CanReschedule(AppointmentModel appointmentRescheduled, AppointmentModel termToReschedule)
        {

            // Rescheduling on the same term of appointment
            if (termToReschedule.IdAppointment == appointmentRescheduled.IdAppointment)
            {
                return (false, "It's the same term of appointment");
            }

            // Check if taken
            using (AppDbContext context = new())
            {
                bool conflict =
                    context.DbAppointments
                    .Any(
                    a =>
                    a.CalendarModel.IdCalendar == termToReschedule.IdCalendar &&
                    a.IdDay == termToReschedule.IdDay &&
                    a.IdTerm == termToReschedule.IdTerm &&
                    a.PatientId != null);

                if (conflict)
                {
                    return (false, "The term to reschedule appointment is already taken");
                }
            }

            // TODO: Validate against rescheduling to the past term

            return (true, "Appointment rescheduled succesfully");
        }
    }
}
