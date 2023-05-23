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
        public static string AddPlans(List<int> checkedTerms, int idDay, int idCalendar, int idEmployee, int idOffice)
        {
            List<DoctorsDayPlanModel> doctorsPlans = GetDoctorsPlanData();
            foreach (int i in checkedTerms)
            {
                foreach (DoctorsDayPlanModel plan in doctorsPlans.ToList())
                {
                    if (plan.IdEmployee == idEmployee && plan.IdDay == idDay && plan.IdCalendar == idCalendar)
                    {
                        return "A plan for this doctor on this day already exists. You have to edit it if you want to apply changes.";                       
                    }

                }
                // TODO: Brak statusu przy tworzeniu
                DoctorsDayPlanModel newPlan = new DoctorsDayPlanModel(i, idDay, idCalendar, idEmployee, idOffice, EnumAppointmentStatus.New);
                AddPlan(newPlan);
            }            
            return "Plan added successfully";
        }

        public static void AddPlan(DoctorsDayPlanModel doctorsDayPlanModel)
        {
            if (CheckIfDoctorIsUnique(doctorsDayPlanModel.IdCalendar, doctorsDayPlanModel.IdEmployee))
            {
                using (AppDbContext context = new AppDbContext())
                {
                    CalendarModel calendar = context.DbCalendars.FirstOrDefault(c => c.IdCalendar == doctorsDayPlanModel.IdCalendar);
                    calendar.NumberOfDoctors += 1;
                    context.SaveChanges();
                }
            }
            using (AppDbContext context = new AppDbContext())
            {
                context.DbDoctorsDayPlan.Add(doctorsDayPlanModel);
                context.SaveChanges();
            }
        }

        public static bool CheckIfDoctorIsUnique(int? idCalendar, int? idEmployee)
        {
            List<DoctorsDayPlanModel> doctorsDayPlanModels = new List<DoctorsDayPlanModel>();
            doctorsDayPlanModels = DoctorsPlanService.GetDoctorsPlanData();

            foreach(DoctorsDayPlanModel doctorsDayPlan in doctorsDayPlanModels)
            {
                if(doctorsDayPlan.IdCalendar == idCalendar && doctorsDayPlan.IdEmployee == idEmployee)
                {
                    return false;
                }
            }

            return true;

            /*bool isUnique = doctorsDayPlanModels
                .Count(e => e.IdCalendar == idCalendar && e.IdEmployee == idEmployee) < 1;

            return isUnique;*/
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
            foreach (DoctorsDayPlanModel plan in doctorsPlans)
            {
                if (plan.IdEmployee == idEmployee && plan.IdDay == idDay && plan.IdCalendar == idCalendar)
                {
                    return plan.IdOfTerm;
                }
            }
            return -1;
        }
        public static List<int> GetBookedTermsOfDoctorForCurrentDay(int idEmployee, int idDay, int idCalendar)
        {
            List<DoctorsDayPlanModel> doctorsPlans = GetDoctorsPlanData();
            List<int> bookedTerms = new List<int>();

            foreach(DoctorsDayPlanModel plan in doctorsPlans)
            {
                if (plan.IdEmployee==idEmployee && plan.IdDay==idDay && plan.IdCalendar == idCalendar)
                {
                    bookedTerms.Add(plan.IdOfTerm);
                }
            }
            return bookedTerms;
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


        public static void RemovePatientFromPlan(DoctorsDayPlanModel plan)
        {
            using (AppDbContext context = new AppDbContext())
            {
                DoctorsDayPlanModel foundPlan = context.DbDoctorsDayPlan.Find(plan.IdDoctorsDayPlan);

                if (foundPlan != null)
                {
                    foundPlan.PatientId = null;
                    foundPlan.Status = EnumAppointmentStatus.Accepted;
                    context.SaveChanges();
                }
            }
        }

    }
}
