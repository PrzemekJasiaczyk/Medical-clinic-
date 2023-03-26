namespace Console_Management_of_medical_clinic.Model
{
    /// <summary>
    /// <c>Visit</c> models a doctor appointment in clinic.
    /// </summary>
    public class Visit
    {
        public int VisitId { get; set; }

        // TODO: Discuss if we really need separate fields for Date and Hour of the visit
        /*
         * We cannot use DateOnly and TimeOnly database, SQLite doesn't support it natively
         * DateTime can easly store just a date, but hardly just a time
         */
        public DateTime VisitDate { get; set; }
        public DateTime VisitHour { get; set; }
        public decimal Cost { get; set; }

        public int? EmployeeId { get; set; }
        public EmployeeModel? Employee { get; set; }

        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }

        // TODO: Create office class and connect to visit class 1:1
        //public int OfficeId { get; set; }
        //public Office Office { get; set; }
    }
}
