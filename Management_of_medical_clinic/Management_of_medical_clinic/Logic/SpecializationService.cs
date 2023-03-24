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
        public static List<SpecializationModel> GetSpecializationsData()
        {
            List<SpecializationModel> specializations = new List<SpecializationModel>();
            using (var db = new AppDbContext())
            {
                specializations = db.DbSpecializations.ToList();
            }

            return specializations;
        }

        public static bool CheckIfSpecializationExists(string newSpecialization)
        {
            List<SpecializationModel> specializations = GetSpecializationsData();
            foreach (SpecializationModel specialization in specializations)
            {
                if (specialization.Name == newSpecialization)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddSpecialization(string specializationToAdd)
        {
            SpecializationModel specialization = new SpecializationModel(specializationToAdd);

            using AppDbContext context = new AppDbContext();

            context.DbSpecializations.Add(specialization);
            context.SaveChanges();
        }

        public static string RemoveSpecialization(string specializationToRemove)
        {
            List<SpecializationModel> specializations = GetSpecializationsData();
            using AppDbContext context = new AppDbContext();

            foreach (SpecializationModel specialization in specializations)
            {
                if (specialization.Name == specializationToRemove)
                {
                    try 
                    {
                        context.DbSpecializations.Remove(specialization);
                        context.SaveChanges();
                        return "Specialization removed successfully";
                    }
                    catch (Exception ex)
                    {
                        return "Specialization is linked to an employee in the database\nIt can not be removed";
                    }
                    
                }
            }    
            return "Specialization doesn't exist";
        }

       

        
    }
}
