using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public static class DoctorsPlanService
    {
        public static List<DoctorsDayPlanModel> GetDoctorsPlanData()
        {
            List<DoctorsDayPlanModel> doctorsPlans = new List<DoctorsDayPlanModel>();
            using (var db = new AppDbContext())
            {
                doctorsPlans = db.DbDoctorsDayPlan.ToList();
            }
            return doctorsPlans;
        }
        public static int GetPlanIdIfAlreadyExists(int idEmployee, int idDay, int idCalendar)
        {
            List<DoctorsDayPlanModel> doctorsPlans = GetDoctorsPlanData();
            foreach (DoctorsDayPlanModel plan in doctorsPlans)
            {
                if (plan.IdEmployee==idEmployee && plan.IdDay==idDay && plan.IdCalendar == idCalendar)
                {
                    return plan.IdDoctorsDayPlan;
                }
            }
            return -1;
        }

        public static void AddPlan(DoctorsDayPlanModel doctorsDayPlanModel)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.DbDoctorsDayPlan.Add(doctorsDayPlanModel);
                context.SaveChanges();
            }
        }

        public static void EditPlan(int idDoctorsDayPlan, int idsWorkingTerms, int idOffice)
        {
            var context = new AppDbContext();
            DoctorsDayPlanModel plan = context.DbDoctorsDayPlan.Find(idDoctorsDayPlan);

            plan.IdOfTerm = idsWorkingTerms;
            plan.IdOffice = idOffice;

            context.SaveChanges();
        }

        public static string GetTermDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var desc = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (desc.Length == 0)
            {
                return desc.ToString();
            }
            else
            {
                return (desc[0] as DescriptionAttribute).Description;
            }
        }
        public static int CheckIfDoctorHasPlanForCurrentDay(int idEmployee, int idDay, int idCalendar)
        {
            List<DoctorsDayPlanModel> doctorsPlans = GetDoctorsPlanData();
            foreach(DoctorsDayPlanModel plan in doctorsPlans)
            {
                if (plan.IdEmployee==idEmployee && plan.IdDay==idDay && plan.IdCalendar == idCalendar)
                {
                    return plan.IdOfTerm;
                }
            }
            return -1;
        }

        public static List<DoctorsDayPlanModel> CheckPlansAndReturnForADay(DateTime selectedDay, int calendarId)
        { 
            using (AppDbContext context  = new AppDbContext())
            {
                return context.DbDoctorsDayPlan.Where(plan => plan.IdDay == selectedDay.Day && plan.IdCalendar == calendarId && selectedDay.DayOfWeek != DayOfWeek.Sunday).ToList();
            }
        }

        public static List<DoctorsDayPlanModel> CheckPlansAndReturnForAMonth(int calendarId)
        {
            string[] dateParts = CalendarService.GetCalendarById(calendarId).DateReference.Split('-');

            using (AppDbContext context = new AppDbContext())
            {
                return context.DbDoctorsDayPlan.AsEnumerable().Where(plan => new DateTime(int.Parse(dateParts[1]), int.Parse(dateParts[0]), plan.IdDay).DayOfWeek != DayOfWeek.Sunday && plan.IdCalendar == calendarId).ToList();
            }
        }

        public static List<DoctorsDayPlanModel> GetPlansByCalendarId(int calendarId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.DbDoctorsDayPlan.Where(plan => plan.IdCalendar == calendarId).ToList();
            }
        }

        public static bool CheckIfAppointmentExists(int idTerm, int idDay, int idCalendar, int idOffice)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.DbDoctorsDayPlan.Any(plan => plan.IdOfTerm == idTerm && plan.IdDay == idDay && plan.IdCalendar == idCalendar && plan.IdOffice == idOffice);
            }
        }
    }
}
