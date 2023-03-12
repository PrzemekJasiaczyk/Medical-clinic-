using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class SpecializationService

    {
        public static void AddSpecialization(string name)
        {
            SpecializationModel specialization = new SpecializationModel(name);

            using AppDbContext context = new AppDbContext();

            context.DbSpecializations.Add(specialization);
            context.SaveChanges();
        }

        public static List<SpecializationModel> GetSpecializationsData()
        {
            List<SpecializationModel> specializations = new List<SpecializationModel>();
            using (var db = new AppDbContext())
            {
                specializations = db.DbSpecializations.ToList();
            }

            return specializations;
        }
    }
}
