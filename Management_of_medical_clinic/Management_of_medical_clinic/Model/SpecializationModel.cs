using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class SpecializationModel
    {
        [Key] public int IdSpecialization { get; set; }
        public string Name { get; set; }

        public List<EmployeeModel> EmployeeModels { get; set; }




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
