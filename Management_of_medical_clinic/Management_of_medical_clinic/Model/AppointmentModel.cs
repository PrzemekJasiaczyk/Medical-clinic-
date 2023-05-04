using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Management_of_medical_clinic.Logic;

namespace Console_Management_of_medical_clinic.Model
{
    public class AppointmentModel
    {
        [Key] public int IdAppointment { get; set; }

        public int IdTerm { get; set; }
        public int IdDay { get; set; }
        public decimal Cost { get; set; } 
        public bool IsActive { get; set; }
        //Relationships
        [ForeignKey("CalendarModel")] public int? IdCalendar { get; set; }
        public CalendarModel CalendarModel { get; set; }
        [ForeignKey("EmployeeModel")] public int? IdEmployee { get; set; }
        public EmployeeModel EmployeeModel { get; set; }
        [ForeignKey("Patient")] public int? PatientId { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("OfficeModel")] public int? IdOffice { get; set; }
        public OfficeModel OfficeModel { get; set; }

        public AppointmentModel() { }

        public AppointmentModel(int idTerm, decimal cost, bool isActive)
        {
            IdTerm = idTerm;
            Cost = cost;
            IsActive = isActive;
        }

        public AppointmentModel(int idTerm, decimal cost, int idDay, bool isActive, int idCalendar, int idEmployee, int patientId, int idOffice)
        {
            IdTerm = idTerm;
            Cost = cost;
            IdDay = idDay;
            IsActive = isActive;
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            PatientId = patientId;
            IdOffice = idOffice;
        }
    }
}
