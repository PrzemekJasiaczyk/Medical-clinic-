using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class OfficeService
    {
        public static List<OfficeModel> GetOfficesData()
        {
            List<OfficeModel> offices;
            using (AppDbContext db = new AppDbContext())
            {
                offices = db.DbOffices.ToList();
            }
            return offices;
        }

        public static void AddOffice(OfficeModel newOffice)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.DbOffices.Add(newOffice);
                db.SaveChanges();
            }
        }

        public static bool CheckIfNumberExists(int number)
        {
            return GetOfficesData().Any(o => o.Number == number);
        }
    }
}
