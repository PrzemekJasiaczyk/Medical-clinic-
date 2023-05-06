using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Data;

namespace MedicalClinicTest
{
    public class CalendarAppointmentServiceTest
    {
        #region Fake Data
        Patient fakePatient = new Patient()
        {
            PatientId = 1000,
            FirstName = "Jan",
            LastName = "Kowalski",
            PESEL = "88010112339",
            Sex = EnumSex.Male,
            BirthDate = new DateTime(1988, 1, 1),
            IsActive = true,
            LastVisitDate = null
        };

        EmployeeModel fakeEmployee = new EmployeeModel()
        {
            IdEmployee = 1000,
            FirstName = "Piotr",
            LastName = "Nowak",
            PESEL= "92013012345",
            DateOfBirth="13-01-1992"
        };

        AppointmentModel firstFakeAppointment = new AppointmentModel()
        {
            IdTerm = 1,
            IdDay = 11,
            Cost = 1000,
            IsActive = false,
            IdCalendar = 1,
            IdEmployee = 1000,
            PatientId = 1000,
            IdOffice = 1
        };

        AppointmentModel secondFakeAppointment = new AppointmentModel()
        {
            IdTerm = 1,
            IdDay = 11,
            Cost = 1000,
            IsActive = true,
            IdCalendar = 1,
            IdEmployee = 1000,
            PatientId = null,
            IdOffice = 1
        };

        #endregion

        #region GetPatientDataByIdPatient

        [Fact]
        public void TestGetPatientDataByIdPatient_Correct()
        {
            AppDbContext context = new AppDbContext();

            Patient patient = fakePatient;
            context.Patients.Add(patient);
            context.SaveChanges();

            EmployeeModel employee = fakeEmployee;
            context.DbEmployees.Add(employee);
            context.SaveChanges();

            AppointmentModel first = firstFakeAppointment; 
            context.DbAppointments.Add(first);
            context.SaveChanges();

            Patient result = CalendarAppointmentService.GetPatientDataByIdPatient(first);

            Assert.NotNull(result);
            Assert.Equal(patient.FirstName, result.FirstName);
            Assert.Equal(patient.LastName, result.LastName);
            Assert.Equal(patient.PESEL, result.PESEL);
            Assert.Equal(patient.Sex, result.Sex);
            Assert.Equal(patient.BirthDate, result.BirthDate);
            Assert.Equal(patient.IsActive, result.IsActive);
            Assert.Equal(patient.LastVisitDate, result.LastVisitDate);

            context.DbAppointments.Remove(first);
            context.DbEmployees.Remove(employee);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        [Fact]
        public void GetPatientDataByIdPatient_PatientNotFound()
        {
            AppointmentModel appointment = new AppointmentModel
            {
                PatientId = 9999
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetPatientDataByIdPatient(appointment));
            Assert.Equal("Patient not found in database", exception.Message);
        }

        [Fact]
        public void GetPatientDataByIdPatient_PatientIsNull()
        {
            AppointmentModel appointment = new AppointmentModel
            {
                PatientId = null
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetPatientDataByIdPatient(appointment));
            Assert.Equal("PatientId = null", exception.Message);
        }

        #endregion

        #region GetAppointmentsWithPatients

        [Fact]
        public void TestGetAppointmentsWithPatients_Include()
        {
            AppDbContext context = new AppDbContext();

            Patient patient = fakePatient;
            context.Patients.Add(patient);
            context.SaveChanges();

            EmployeeModel employee = fakeEmployee;
            context.DbEmployees.Add(employee);
            context.SaveChanges();

            AppointmentModel first = firstFakeAppointment;
            context.DbAppointments.Add(first);
            context.SaveChanges();

            List<AppointmentModel> result = CalendarAppointmentService.GetAppointmentsWithPatients();

            Assert.Contains(result, a => a.IdAppointment == first.IdAppointment);

            context.DbAppointments.Remove(first);
            context.DbEmployees.Remove(employee);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        [Fact]
        public void TestGetAppointmentsWithPatients_NotInclude()
        {
            AppDbContext context = new AppDbContext();

            EmployeeModel employee = fakeEmployee;
            context.DbEmployees.Add(employee);
            context.SaveChanges();

            AppointmentModel second = secondFakeAppointment;
            context.DbAppointments.Add(second);
            context.SaveChanges();

            List<AppointmentModel> result = CalendarAppointmentService.GetAppointmentsWithPatients();

            Assert.DoesNotContain(result, a => a.IdAppointment == second.IdAppointment);

            context.DbAppointments.Remove(second);
            context.DbEmployees.Remove(employee);
            context.SaveChanges();
        }

        #endregion

    }
}
