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
			PatientModel patient = PatientModel.FindPatient(1);
			Assert.NotNull(patient);
		}

		[Fact]
		public void FindNotExistingPatientInDataBase()
		{
			PatientModel patient = PatientModel.FindPatient(999);
			Assert.Null(patient);
		}

		[Fact]

		public void AddPatientToDataBase()
		{
			AppDbContext testContext;

			using (InMemoryDbContext inMemoryDbContext = new InMemoryDbContext())
			{
				testContext = inMemoryDbContext.CreateTestContext();
				PatientModel patient =
				new PatientModel()
				{
					FirstName = "Paweł",
					LastName = "Dawid",
					PESEL = "45010195612",
					Sex = EnumSex.Male,
					BirthDate = new DateTime(1945, 1, 1),
					IsActive = true,
					LastVisitDate = null
				};

                inMemoryDbContext.Dispose();
                
				int before = testContext.Patients.Count();
                PatientModel.AddPatient(patient, testContext);

				int after = testContext.Patients.Count();

				Assert.Equal(before+1, after);
			}
		}
    }
}
