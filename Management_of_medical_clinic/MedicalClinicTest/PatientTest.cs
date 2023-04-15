using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;

namespace MedicalClinicTest
{
	public class PatientTest
	{
		// Natalia: dodawanie, znajdywanie pacjenta

		[Fact]

		public void AddPatientToDataBase()
		{
			AppDbContext testContext;

			using (InMemoryDbContext inMemoryDbContext = new())
			{
				testContext = inMemoryDbContext.CreateTestContext();
                Patient patient =
                new Patient()
                {
                    FirstName = "Paweł",
                    LastName = "Wiktorowicz",
                    PESEL = "99030300191",
                    Sex = EnumSex.Male,
                    BirthDate = new DateTime(1999, 3, 3),
                    IsActive = true,
                    LastVisitDate = null
                };

                Patient.AddPatient(patient, testContext);
                

            }
		}
    }
}
