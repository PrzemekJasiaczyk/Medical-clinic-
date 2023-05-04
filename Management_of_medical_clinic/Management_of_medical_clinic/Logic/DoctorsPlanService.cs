using Console_Management_of_medical_clinic.Data;
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
        public static void AddAppointment(DoctorsDayPlanModel doctorsDayPlanModel)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.DbDoctorsDayPlan.Add(doctorsDayPlanModel);
                context.SaveChanges();
            }
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
    }
}
