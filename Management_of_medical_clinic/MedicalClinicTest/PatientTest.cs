using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using MedicalClinicTest.TestData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MedicalClinicTest
{
	public class PatientTest
	{
		[Fact]
		public void FindExistingPatientInDataBase()
		{
			Patient patient = Patient.FindPatient(1);
			Assert.NotNull(patient);
		}

		[Fact]
		public void FindNotExistingPatientInDataBase()
		{
			Patient patient = Patient.FindPatient(999);
			Assert.Null(patient);
		}


		//[Fact]

		//public void AddPatientToDataBase()
		//      {
		//	AppDbContext testContext;

		//          using (InMemoryDbContext inMemoryDbContext = new InMemoryDbContext())
		//	{
		//		testContext = inMemoryDbContext.CreateTestContext();
		//		Patient patient =
		//		new Patient()
		//		{
		//			FirstName = "Paweł",
		//			LastName = "Dawid",
		//			PESEL = "45010195612",
		//			Sex = EnumSex.Male,
		//			BirthDate = new DateTime(1945, 1, 1),
		//			IsActive = true,
		//			LastVisitDate = null
		//		};

		//		Patient.AddPatient(patient, testContext);
		//	}
		//}

		[Fact]
		public void AddPatientToDataBase()
		{
            Patient patient = new Patient()
            {
                FirstName = "Paweł",
                LastName = "Dawid",
                PESEL = "45010195612",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1945, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };
			using (AppDbContext dbContext = new AppDbContext())
			{
				Patient.AddPatient(patient, dbContext);				
			}
        }



    }
}
