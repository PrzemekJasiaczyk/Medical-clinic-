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

		#region IsValid Method Tests
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

        [Fact]
        public void IsValidPESEL_TooShort()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "9001011234",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL, patient.BirthDate,
                patient.Sex, out errorMessage);

            Assert.False(result);
            Assert.True(errorMessage == "Given PESEL is too short. It should have 11 digits.");

        }
        [Fact]
        public void IsValidPESEL_TooLong()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "9001011234599",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);

            Assert.False(result);
            Assert.True(errorMessage == "Given PESEL is too long. It should have 11 digits.");

        }
        [Fact]
        public void IsValidPESEL_Correct()
        {
            string errorMessage = string.Empty;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "90010112335",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);


            Assert.True(result);
            Assert.Equal("", errorMessage);
        }

        [Fact]
        public void IsValidPESEL_Empty()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);


            Assert.True(errorMessage == "PESEL cannot be empty. It should 11 digits.");
            Assert.False(result);
        }
        [Fact]
        public void IsValidPESEL_letters()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "900101a2345",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);


            Assert.True(errorMessage == "PESEL cannot contain letters or special characters");
            Assert.False(result);
        }
        [Fact]
        public void IsValidPESEL_SpecialCharacters()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "900101@2345",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);


            Assert.True(errorMessage == "PESEL cannot contain letters or special characters");
            Assert.False(result);
        }

        [Fact]
        public void IsValidPESEL_notMatch()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "90010112345",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 2, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);


            Assert.True(errorMessage == "PESEL has incorrect birth date");
            Assert.False(result);
        }

        [Fact]
        public void IsValidPESEL_incorrectGenderMale()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "90010112245",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);


            Assert.True(errorMessage == "PESEL has incorrect gender. For men it's an odd number.");
            Assert.False(result);
        }


        [Fact]
        public void IsValidPESEL_incorrectGenderFemale()
        {
            string errorMessage;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Anna",
                LastName = "Nowak",
                PESEL = "90020201578",
                Sex = EnumSex.Female,
                BirthDate = new DateTime(1990, 2, 2),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidPESEL(patient.PESEL,
                patient.BirthDate, patient.Sex, out errorMessage);


            Assert.True(errorMessage == "PESEL has incorrect gender. For women it's 0 or even number");
            Assert.False(result);
        }


        [Fact]
        public void IsValidPESEL_unique()
        {
            string errorMessage;
            var dbContext = new AppDbContext();
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "90010112335",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };

            Patient.AddPatient(patient, dbContext);
            dbContext.SaveChanges();
            Patient patient2 = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "90010112335",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(1990, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };
            bool result = patientService.IsValidPESEL(patient2.PESEL,
                patient2.BirthDate, patient2.Sex, out errorMessage);

            Assert.False(result);
            Assert.True(errorMessage == "PESEL is not unique. Patient with given PESEL already exist");

            dbContext.Patients.Remove(patient);
            dbContext.SaveChanges();
        }


        [Fact]
        public void isValidDate_DateFromFuture()
        {
            string errorMessage = string.Empty;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "90010112335",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(2100, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidDate(patient.BirthDate,out errorMessage);


            Assert.False(result);
            Assert.Equal("Birth date cannot be in the future", errorMessage);
        }

        [Fact]
        public void isValidDate_Correct()
        {
            string errorMessage = string.Empty;
            PatientService patientService = new();
            Patient patient = new Patient()
            {
                FirstName = "Jan",
                LastName = "Nowak",
                PESEL = "90010112335",
                Sex = EnumSex.Male,
                BirthDate = new DateTime(2010, 1, 1),
                IsActive = true,
                LastVisitDate = null
            };


            bool result = patientService.IsValidDate(patient.BirthDate, out errorMessage);


            Assert.True(result);
            Assert.Equal("", errorMessage);
        }
    }
}
        

	
