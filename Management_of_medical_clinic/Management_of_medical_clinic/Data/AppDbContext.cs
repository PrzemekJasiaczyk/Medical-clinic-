using Console_Management_of_medical_clinic.Data.EntityTypeConfigurations;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;

namespace Console_Management_of_medical_clinic.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CalendarModel> DbCalendars { get; set; }
        public DbSet<AppointmentModel> DbAppointments{ get; set; }
        public DbSet<UserModel> DbUsers { get; set; }        
        public DbSet<SpecializationModel> DbSpecializations { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<EmployeeModel> DbEmployees { get; set; }
        public DbSet<DoctorsDayPlanModel> DbDoctorsDayPlan { get; set; }
        public DbSet<OfficeModel> DbOffices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //MIGRATION STRING
            //string CustomPath = Directory.GetCurrentDirectory() + "\\..\\Database\\DbMain.db";

            //NORMAL USE STRING
            string CustomPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\Database\\DbMain.db";

            optionsBuilder.UseSqlite(@"Data Source = " + CustomPath);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PatientEntityTypeConfiguration().Configure(modelBuilder.Entity<Patient>());
            new VisitEntityTypeConfiguration().Configure(modelBuilder.Entity<Visit>());

            new PatientEntityTypeConfiguration().Seed(modelBuilder.Entity<Patient>());
            base.OnModelCreating(modelBuilder);
        }
    }    
}
