using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Data;

namespace MedicalClinicTest
{
	public class PatientServiceTest
	{
		#region Reusable Fake Data
		Patient _firstFakePatient = new Patient()
		{
			FirstName = "Pawe³",
			LastName = "Dawid",
			PESEL = "45010195612",
			Sex = EnumSex.Male,
			BirthDate = new DateTime(1945, 1, 1),
			IsActive = true,
			LastVisitDate = null
		};

		Patient _secondFakePatient = new Patient()
		{
			FirstName = "Jan",
			LastName = "Wiktorowicz",
			PESEL = "99030300191",
			Sex = EnumSex.Male,
			BirthDate = new DateTime(1999, 3, 3),
			IsActive = true,
			LastVisitDate = null
		};

		#endregion

		#region Tests Expected Results

		[Fact]
		public void IsValidName_NotNullName()
		{
			string errorMessage;
			PatientService patientService = new();

			Patient patient = _firstFakePatient;

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.True(isValid);
			Assert.True(errorMessage == "");
		}

		[Fact]
		public void IsValidName_NameWithSpace()
		{
			string errorMessage;
			PatientService patientService = new();

			Patient patient = _firstFakePatient;
			_firstFakePatient.FirstName = "Juan Pablo";

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.True(isValid);
			Assert.True(errorMessage == "");
		}

		[Fact]
		public void IsValidName_NameWithDashes()
		{
			string errorMessage;
			PatientService patientService = new();

			Patient patient = _firstFakePatient;
			_firstFakePatient.LastName = "Œwiderska-¯anecka";

			bool isValid = patientService.IsValidName(patient.LastName, out errorMessage);

			Assert.True(isValid);
			Assert.True(errorMessage == "");
		}

		[Fact]
		public void GetPatientsData_ExpectedResult()
		{
			AppDbContext dbContext = new();
			PatientService patientService = new();

			dbContext.Patients.AddRange(_firstFakePatient, _secondFakePatient);
			dbContext.SaveChanges();

			var result = patientService.GetPatientData();

			Assert.NotNull(result);
			Assert.Contains(result, p => p.PESEL == "45010195612");
			Assert.Contains(result, p => p.PESEL == "99030300191");

			dbContext.Patients.RemoveRange(_firstFakePatient, _secondFakePatient);
			dbContext.SaveChanges();
		}

		#endregion

		#region Tests Unexpected Results

		[Fact]
		public void IsValidName_NullName()
		{
			string errorMessage;
			PatientService patientService = new();

			Patient patient = _firstFakePatient;
			patient.FirstName = null;

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.False(isValid);
			Assert.True(errorMessage == "This field cannot be left empty");
		}

		[Fact]
		public void IsValidName_WhiteSpace()
		{
			string errorMessage;
			PatientService patientService = new();

			Patient patient = _firstFakePatient;
			patient.FirstName = " ";

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.False(isValid);
			Assert.True(errorMessage == "This field cannot be left empty");
		}

		[Fact]
		public void IsValidName_AboveSixtyCharacters()
		{
			string errorMessage;
			PatientService patientService = new();

			Patient patient = _firstFakePatient;

			patient.FirstName = "Pedro Maria Alvarez Silvio Juan Pablo Emanuel Ulrich Jan Pawe³ Gawe³ Luffy Zoro Saitama Stanis³aw";

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.False(isValid);
			Assert.True(errorMessage == "It cannot be longer than 60 signs");
		}

		[Fact]
		public void IsValidName_Digits()
		{
			string errorMessage;
			PatientService patientService = new();
			Patient patient = _firstFakePatient;

			patient.FirstName = "1234 Jan Gawe³";

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.False(isValid);
			Assert.True(errorMessage == "Name should be letters only");
		}

		[Fact]
		public void IsValidName_SpecialSigns()
		{
			string errorMessage;
			PatientService patientService = new();
			Patient patient = _firstFakePatient;

			patient.FirstName = "Ruda @";

			bool isValid = patientService.IsValidName(patient.FirstName, out errorMessage);

			Assert.False(isValid);
			Assert.True(errorMessage == "Name should be letters only");
		}

		#endregion
	}
}