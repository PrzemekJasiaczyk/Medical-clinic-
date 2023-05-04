using Console_Management_of_medical_clinic.Data.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class OfficeModel
    {

        [Key] public int IdOffice { get; set; }
        
        public int Number { get; set; }
        public EnumOfficeStatuses Status { get; set; }
        public string Info { get; set; }
        //Relationships
        [ForeignKey("SpecializationModel")] public int IdSpecialization { get; set; }
        public SpecializationModel? SpecializationModel { get; set; }

        public OfficeModel() { }

        public OfficeModel(int number, int idSpecialization, EnumOfficeStatuses status, string info)
        {
            Number = number;
            IdSpecialization = idSpecialization;
            Status = status;
            Info = info;
        }

        public override string ToString()
        {
            return Number.ToString() + " - " + Status + " - " + Info;
        }
        
    }
}
