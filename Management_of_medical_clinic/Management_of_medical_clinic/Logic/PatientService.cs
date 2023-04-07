using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;

namespace Console_Management_of_medical_clinic.Logic
{
    public class PatientService
    {
        public List<Patient> GetPatientData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.ToList();
            }
        }

        // TODO: Digits and special characters
        public bool IsValidName(string patientName, out string errorMessage)
        {
            // White space checking
            if (string.IsNullOrWhiteSpace(patientName)) 
            {
                errorMessage = "This field cannot be left empty";
                return false; 
            }

            // Length checking
            if (patientName.Length > 60) 
            {
                errorMessage = "It cannot be longer than 60 signs";
                return false; 
            }

            // Characters checking
            bool onlyLetters = Regex.IsMatch(patientName, @"^[A-ZĄĆĘŁŃÓŚŹŻa-ząćęłńóśźż -]+$");

            if (!onlyLetters) 
            {
                errorMessage = "Name should be letters only";
                return false;
            }


            errorMessage = "";
            return true;
        }

        public bool IsValidDate(DateTime date, out string errorMessage)
        {
            // Checking if earlier than tommorow
            if (date > DateTime.Now) 
            {
                errorMessage = "Birth date cannot be in the future";
                return false; 
            }

            errorMessage = "";
            return true;
        }

        public bool IsValidPESEL(Patient patient, out string errorMessage)
        {
			// Length checking
			int length = patient.PESEL.Length;

			if (length != 11)
			{
				if (length == 0)
				{
                    errorMessage = "PESEL cannot be empty. It should 11 digits.";
				}
				else if (length < 11)
				{
                    errorMessage = "Given PESEL is too short. It should have 11 digits.";
				}
				else
				{
                    errorMessage = "Given PESEL is too long. It should have 11 digits.";
				}

				return false;
			}

            // Characters checking
            bool onlyDigits = Regex.IsMatch(patient.PESEL, @"^\d+$");

            if (!onlyDigits ) 
            {
                errorMessage = "PESEL cannot contain letters or special characters";
                return false;
            }

			// Birth date checking
			string dateOfBirth = patient.BirthDate.ToString("yy/MM/dd");
            dateOfBirth = dateOfBirth.Replace("/", "");

            string pattern = $@"^{dateOfBirth}\d*";
            bool isMatch = Regex.IsMatch(patient.PESEL, pattern);

            if (!isMatch) 
            {
                errorMessage = "PESEL has incorrect birth date";
                return false;
            }

            // Gender checking
            int genderNumber = (int)patient.PESEL[9];

            if (patient.Sex == EnumSex.Male && genderNumber % 3 != 0 || genderNumber == 0) 
            {
                errorMessage = "PESEL has incorrect gender. For men it's an odd number.";
                return false;
            }
            else if (patient.Sex == EnumSex.Female && genderNumber % 2 != 0) 
            {
				errorMessage = "PESEL has incorrect gender. For women it's 0 or even number";
				return false;
            }
            
            // Uniqueness checking
            using (AppDbContext context = new())
            {
                bool patientExist = context.Patients.Any(p => p.PESEL == patient.PESEL);

                if (patientExist) 
                {
                    errorMessage = "PESEL is not unique. Patient with given PESEL already exist";
                    return false;
                }
            }

            errorMessage = "";
            return true;
        }
    }
}
