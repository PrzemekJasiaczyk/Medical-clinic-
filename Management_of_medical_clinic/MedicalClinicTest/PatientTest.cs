using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;

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

		[Fact]
		public void AddPatientToDataBase()
		{
			var dbContext = new AppDbContext();

			Patient patient =
			new Patient()
			{
				FirstName = "Paweł",
				LastName = "Dawid",
				PESEL = "45010195612",
				Sex = EnumSex.Male,
				BirthDate = new DateTime(1945, 1, 1),
				IsActive = true,
				LastVisitDate = null
			};

			Patient.AddPatient(patient, dbContext);
			dbContext.SaveChanges();

			var addedPatient = dbContext.Patients.Find(patient.PatientId);

			Assert.NotNull(addedPatient);
			Assert.True(addedPatient.FirstName == patient.FirstName);
			Assert.True(addedPatient.LastName == patient.LastName);
			Assert.True(addedPatient.Sex == patient.Sex);
			Assert.True(addedPatient.BirthDate == patient.BirthDate);
			Assert.True(addedPatient.IsActive == patient.IsActive);

			dbContext.Patients.Remove(patient);
			dbContext.SaveChanges();
		}
	}
}