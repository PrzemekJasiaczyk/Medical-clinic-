using Console_Management_of_medical_clinic.Data.Enums;

namespace Console_Management_of_medical_clinic.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string PESEL { get; set; }
        public EnumSex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastVistiDate { get; set; }

        public List<Visit> Visits { get; set; } = new List<Visit>();
    }
}
