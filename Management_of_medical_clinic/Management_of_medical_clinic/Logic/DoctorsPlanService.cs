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

        public static void EditPlan(int idDoctorsDayPlan, string idsWorkingTerms, int idOffice)
        {
            var context = new AppDbContext();
            DoctorsDayPlanModel plan = context.DbDoctorsDayPlan.Find(idDoctorsDayPlan);

            plan.IdsWorkingTerms = idsWorkingTerms;
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
        public static string CheckIfDoctorHasPlanForCurrentDay(int idEmployee, int idDay, int idCalendar)
        {
            List<DoctorsDayPlanModel> doctorsPlans = GetDoctorsPlanData();
            foreach(DoctorsDayPlanModel plan in doctorsPlans)
            {
                if (plan.IdEmployee==idEmployee && plan.IdDay==idDay && plan.IdCalendar == idCalendar)
                {
                    return plan.IdsWorkingTerms;
                }
            }
            return "";
        }
    }
}
