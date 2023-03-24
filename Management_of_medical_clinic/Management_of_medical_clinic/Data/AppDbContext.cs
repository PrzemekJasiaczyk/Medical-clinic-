using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<EmployeeModel> DbEmployees { get; set; }
        public DbSet<SpecializationModel> DbSpecializations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //STRING DO UŻYWANIA PODCZAS MIGRACJI
            //string CustomPath = Directory.GetCurrentDirectory() + "\\..\\Database\\DbMain.db";

            //STRING DO NORMALNEGO UŻYTKU
            string CustomPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\Database\\DbMain.db";

            optionsBuilder.UseSqlite(@"Data Source = " + CustomPath);


        }
    }    
}
