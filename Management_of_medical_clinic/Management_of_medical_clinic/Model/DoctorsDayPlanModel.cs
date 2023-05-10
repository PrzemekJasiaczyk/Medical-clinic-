using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class DoctorsDayPlanModel
    {
        [Key] public int IdDoctorsDayPlan { get; set; }
        public string IdsWorkingTerms { get; set; }
        public int IdDay { get; set; }
        public bool IsActive { get; set; }
        //Relationships
        [ForeignKey("CalendarModel")] public int? IdCalendar { get; set; }
        public CalendarModel CalendarModel { get; set; }
        [ForeignKey("EmployeeModel")] public int? IdEmployee { get; set; }
        public EmployeeModel EmployeeModel { get; set; }
        [ForeignKey("OfficeModel")] public int? IdOffice { get; set; }
        public OfficeModel OfficeModel { get; set; }

        public DoctorsDayPlanModel() { }

        public DoctorsDayPlanModel(string idsWorkingTerms, bool isActive)
        {
            IdsWorkingTerms = idsWorkingTerms;
            IsActive = isActive;
        }

        public DoctorsDayPlanModel(string idsWorkingTerms, int idDay, int idCalendar, int idEmployee, int idOffice, bool isActive)
        {
            IdsWorkingTerms = idsWorkingTerms;
            IdDay = idDay;
            IsActive = isActive;
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
        }

        public DoctorsDayPlanModel(int idDoctorsDayPlan, string idsWorkingTerms, int idDay, bool isActive, int idCalendar, int idEmployee, int idOffice)
        {
            IdDoctorsDayPlan = idDoctorsDayPlan;
            IdsWorkingTerms = idsWorkingTerms;
            IdDay = idDay;
            IsActive = isActive;
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
        }
    }
}
