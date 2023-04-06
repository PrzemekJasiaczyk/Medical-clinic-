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
        public DateTime BirthDate { get; set; } // TODO: Check if a date is not later than today
        public bool IsActive { get; set; }
        public DateTime? LastVisitDate;
        // TODO: LastVisitDate - autogenerate
        // Visits?.Where(v => v.Date <= DateTime.Today).OrderByDescending(v => v.Date).FirstOrDefault()?.Date;

        public List<Visit> Visits { get; set; } = new List<Visit>();

        public static void ChangePatientStatus(Patient patient)
        {
            AppDbContext _context = new AppDbContext();
            
            if (patient.IsActive == true)
            {
                patient = _context.Patients.Find(patient.PatientId);
                patient.IsActive = false;
                _context.SaveChanges();
                return;
            }
            else if (patient.IsActive == false)
            {
                patient = _context.Patients.Find(patient.PatientId); // for remove
                patient.IsActive = true;
                _context.SaveChanges();
                return;
            }
        }

        public static Patient FindPatient(int PatientId)
        {
            AppDbContext _context = new AppDbContext();
            
            Patient patient = new Patient();
            patient = _context.Patients.Find(PatientId);
            return patient;
        }

        public static void RemovePatient(Patient patient)
        {
            AppDbContext _context = new AppDbContext();

            _context.Patients.Remove(patient);
            _context.SaveChanges();
            return;
        }
    }
}
