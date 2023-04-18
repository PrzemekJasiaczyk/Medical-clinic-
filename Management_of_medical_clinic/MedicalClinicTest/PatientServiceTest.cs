using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Data;

namespace MedicalClinicTest
{
	public class PatientServiceTest
	{

		[Fact]
		public void GetPatients_ExpectedResults()
		{
			AppDbContext dbContext = new();
			PatientService patientService = new();

			Patient firstPatient = new()
			{
				FirstName = "Pawe³",
				LastName = "Dawid",
				PESEL = "45010195612",
				Sex = EnumSex.Male,
				BirthDate = new DateTime(1945, 1, 1),
				IsActive = true,
				LastVisitDate = null
			};

			Patient secondPatient = new()
			{
				FirstName = "Jan",
				LastName = "Wiktorowicz",
				PESEL = "99030300191",
				Sex = EnumSex.Male,
				BirthDate = new DateTime(1999, 3, 3),
				IsActive = true,
				LastVisitDate = null
			};

			dbContext.Patients.AddRange(firstPatient, secondPatient);
			dbContext.SaveChanges();

			var result = patientService.GetPatientData();

			Assert.NotNull(result);
			Assert.True(result.Count >= 2);
			Assert.Contains(result, p => p.PESEL == "45010195612");
			Assert.Contains(result, p => p.PESEL == "99030300191");

			dbContext.Patients.RemoveRange(firstPatient, secondPatient);
			dbContext.SaveChanges();
		}

		[Fact]
		public void NullNameTest()
		{
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

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.False(isValid);
			Assert.True(errorMessage == "This field cannot be left empty");
		}
	}
}