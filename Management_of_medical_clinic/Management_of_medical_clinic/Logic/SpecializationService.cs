using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;

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

        public static void RemoveSpecialization(string specializationToRemove)
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
                        return;
                    }
                    catch (Exception ex)
                    {
                        return;
                    }                    
                }
            }    
        }
        
        public static int getSpecializationIdByName(string name)
        {
            List<SpecializationModel> specializations = GetSpecializationsData();
            foreach(SpecializationModel specialization in specializations)
            {
                if (specialization.Name == name)
                {
                    return specialization.IdSpecialization;
                }
            }
            return 0;
        }

        public static bool checkIfSpecializationIsAssigned(List<EmployeeModel> Employees, int idSpecialization)
        {
            foreach(EmployeeModel employee in Employees)
            {
                if (employee.IdSpecialization == idSpecialization)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
