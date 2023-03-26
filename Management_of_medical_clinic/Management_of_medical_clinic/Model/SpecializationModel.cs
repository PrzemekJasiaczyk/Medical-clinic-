using System.ComponentModel.DataAnnotations;

namespace Console_Management_of_medical_clinic.Model
{
    public class SpecializationModel
    {
        [Key] public int IdSpecialization { get; set; }
        public string Name { get; set; }

        public SpecializationModel() { }

        public SpecializationModel(string name)
        {
            Name = name;
        }

        public SpecializationModel(int idSpecialization ,string name)
        {
            IdSpecialization = idSpecialization;
            Name = name;            
        }
    }    
}
