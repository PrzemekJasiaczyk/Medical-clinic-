namespace Console_Management_of_medical_clinic.Model
{
    public class Visit
    {
        public int VisitId { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime VisitHour { get; set; }
        public decimal Cost { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        // TODO: Create office class and connect to visit class 1:1
        //public int OfficeId { get; set; }
        //public Office Office { get; set; }
    }
}
