using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Data.Enums;

namespace MedicalClinicTest
{
	public class PatientServiceTest
	{
		[Fact]
		public void NullNameTest()
		{
			AppDbContext testContext;
			string errorMessage;
			PatientService patientService = new();
			
			Patient patient =
				new Patient()
				{
					FirstName = null,
					LastName = "Wiktorowicz",
					PESEL = "99030300191",
					Sex = EnumSex.Male,
					BirthDate = new DateTime(1999, 3, 3),
					IsActive = true,
					LastVisitDate = null
				};

			using (InMemoryDbContext inMemoryDbContext = new())
			{
				testContext = inMemoryDbContext.CreateTestContext();
			}

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.False(isValid);
			Assert.True(errorMessage == "This field cannot be left empty");
		}
	}
}