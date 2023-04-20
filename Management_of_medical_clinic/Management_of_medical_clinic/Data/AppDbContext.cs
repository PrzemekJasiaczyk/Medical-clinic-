﻿using Console_Management_of_medical_clinic.Data.EntityTypeConfigurations;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;

namespace Console_Management_of_medical_clinic.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<UserModel> DbUsers { get; set; }        
        public DbSet<SpecializationModel> DbSpecializations { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<EmployeeModel> DbEmployees { get; set; }

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
            new PatientEntityTypeConfiguration().Configure(modelBuilder.Entity<PatientModel>());
            new VisitEntityTypeConfiguration().Configure(modelBuilder.Entity<Visit>());

            new PatientEntityTypeConfiguration().Seed(modelBuilder.Entity<PatientModel>());
            base.OnModelCreating(modelBuilder);
        }
    }    
}
