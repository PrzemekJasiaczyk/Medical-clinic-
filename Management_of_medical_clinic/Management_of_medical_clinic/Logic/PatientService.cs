using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;

namespace Console_Management_of_medical_clinic.Logic
{
    public class PatientService
    {
        public List<Patient> GetPatientData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.ToList();
            }
        }
    }
}
