namespace Console_Management_of_medical_clinic.Model
{
    // TODO: Think about deleting or repurposing this class
    public class Visit
    {
        public int VisitId { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime VisitHour { get; set; }
        public decimal Cost { get; set; }

        public int? EmployeeId { get; set; }
        public EmployeeModel? Employee { get; set; }

        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
