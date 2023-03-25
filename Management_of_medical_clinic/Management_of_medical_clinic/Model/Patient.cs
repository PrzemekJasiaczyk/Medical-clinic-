using Console_Management_of_medical_clinic.Data.Enums;

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
        public string PESEL { get; set; }
        public EnumSex Sex { get; set; }
        public DateOnly BirthDate { get; set; }
        public bool IsActive { get; set; }
        public DateOnly? LastVistiDate; // TODO: Last visit date should be calculated based on Visits list

        public List<Visit> Visits { get; set; } = new List<Visit>();
    }
}
