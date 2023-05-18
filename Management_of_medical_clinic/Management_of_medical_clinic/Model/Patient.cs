using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Console_Management_of_medical_clinic.Model
{
    /// <summary>
    /// <c>Patient</c> models a patient registered in clinic.
    /// <c>Visit</c> list contains visits for a patient object.
    /// </summary>
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "PESEL must contain exactly 11 digits.")]
        public string PESEL { get; set; }

        public EnumSex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastVisitDate;

        public List<Visit> Visits { get; set; } = new List<Visit>();

        public static void ChangePatientStatus(Patient patient, AppDbContext context)
        {
            patient = context.Patients.Find(patient.PatientId);
            
            if (patient.IsActive == true)
            {
                patient.IsActive = false;
            }
            else
            {
                patient.IsActive = true;
            }
            
            context.SaveChanges();
        }

        public static Patient FindPatient(int PatientId)
        {
            AppDbContext _context = new AppDbContext();

            Patient patient = _context.Patients.Find(PatientId);
            return patient;
        }

        public static void RemovePatient(Patient patient, AppDbContext context)
        {
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        public static void AddPatient(Patient patient, AppDbContext context)
        {
            context.Patients.Add(patient);
            context.SaveChanges();
        }


        public override string ToString()
        {
            return LastName + " " + FirstName;
        }
    }
}
