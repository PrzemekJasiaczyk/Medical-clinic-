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
			var dbContext = new AppDbContext();

			Patient patient =
			new Patient()
			{
<<<<<<< HEAD
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
=======
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
>>>>>>> c52c2b10ba5f90c3698f33f1580ff0247dbd70fa

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


        [Fact]
        public void TestActivatePatient()
        {
            AppDbContext dbContext = new AppDbContext();

            Patient patient = new Patient()
            {
                FirstName = "Paweł",
                LastName = "Dawid",
                PESEL = "45010195612",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1945, 1, 1),
                IsActive = false,
                LastVisitDate = null
            };

            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();

            Patient.ChangePatientStatus(patient, dbContext);
            Patient activatedPatient = dbContext.Patients.Find(patient.PatientId);

            Assert.True(activatedPatient.IsActive);

            dbContext.Patients.Remove(patient);
            dbContext.SaveChanges();
        }

        [Fact]
        public void TestDeactivatePatient()
        {
            AppDbContext dbContext = new AppDbContext();

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

            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();

            Patient.ChangePatientStatus(patient, dbContext);
            Patient deactivatedPatient = dbContext.Patients.Find(patient.PatientId);

            Assert.False(deactivatedPatient.IsActive);

            dbContext.Patients.Remove(patient);
            dbContext.SaveChanges();
        }

        [Fact]
        public void TestRemovePatient()
        {
            AppDbContext dbContext = new AppDbContext();

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

            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();

            Patient.RemovePatient(patient, dbContext);
            Patient removedPatient = dbContext.Patients.Find(patient.PatientId);

            Assert.Null(removedPatient);
        }
    }
}