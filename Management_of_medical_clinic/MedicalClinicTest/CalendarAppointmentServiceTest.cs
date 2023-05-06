using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
            PESEL = "92013012345",
            DateOfBirth = "13-01-1992"
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

        AppointmentModel thirdFakeAppointment = new AppointmentModel()
        {
            IdTerm = 3,
            IdDay = 3,
            Cost = 1000,
            IsActive = true,
            IdCalendar = 1,
            IdEmployee = 3,
            PatientId = 1,
            IdOffice = 1
        };

        AppointmentModel fourthFakeAppointment = new AppointmentModel()
        {
            IdTerm = 4,
            IdDay = 4,
            Cost = 1000,
            IsActive = true,
            IdCalendar = 1,
            IdEmployee = 4,
            PatientId = 4,
            IdOffice = 2
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

        #region GetLastNameAndNameOfEmployeeByAppointment

        [Fact]
        public void TestGetLastNameAndNameOfEmployeeByAppointment_Correct()
        {
            AppDbContext context = new AppDbContext();

            EmployeeModel employee = fakeEmployee;
            context.DbEmployees.Add(employee);
            context.SaveChanges();

            Patient patient = fakePatient;
            context.Patients.Add(patient);
            context.SaveChanges();

            AppointmentModel first = firstFakeAppointment;
            first.IdEmployee = employee.IdEmployee;
            context.DbAppointments.Add(first);
            context.SaveChanges();

            string result = CalendarAppointmentService.GetLastNameAndNameOfEmployeeByAppointment(first);

            Assert.Equal(employee.FirstName + " " + employee.LastName, result);

            context.DbAppointments.Remove(first);
            context.DbEmployees.Remove(employee);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        [Fact]
        public void TestGetLastNameAndNameOfEmployeeByAppointment_EmployeeNotFound()
        {
            AppointmentModel appointment = new AppointmentModel
            {
                IdEmployee = 9999
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetLastNameAndNameOfEmployeeByAppointment(appointment));
            Assert.Equal("Employee not found in database", exception.Message);
        }

        [Fact]
        public void TestGetLastNameAndNameOfEmployeeByAppointment_EmployeeIsNull()
        {
            AppointmentModel appointment = new AppointmentModel
            {
                IdEmployee = null
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetLastNameAndNameOfEmployeeByAppointment(appointment));
            Assert.Equal("IdEmployee = null", exception.Message);
        }

        #endregion

        #region AppointmentInSelectedDate
        [Fact]
        public void TestappointmentInSelectedDate_Correct()
        {
            DateTime selectedDate = new DateTime(2023, 05, 06);
            int idCalendar = 1;
            List<AppointmentModel> appointments = new List<AppointmentModel>()
            {
            new AppointmentModel 
            {
                IdTerm = 3,
                IdDay = 6,
                Cost = 150,
                IsActive = true,
                IdCalendar = 1,
                IdEmployee = 3,
                PatientId = 1,
                IdOffice = 1
            },
            new AppointmentModel 
            { 
                IdTerm = 4,
                IdDay = 6,
                Cost = 150,
                IsActive = true,
                IdCalendar = 1,
                IdEmployee = 3,
                PatientId = 1,
                IdOffice = 1 
            },
            new AppointmentModel 
            {  
                IdTerm = 3,
                IdDay = 6,
                Cost = 100,
                IsActive = true,
                IdCalendar = 2,
                IdEmployee = 3,
                PatientId = 1,
                IdOffice = 1 }
            };

            List<AppointmentModel> result = CalendarAppointmentService.appointmentInSelectedDate(appointments, selectedDate, idCalendar);

            Assert.Equal(2, result.Count);
            Assert.All(result, appointment => Assert.Equal(1, appointment.IdCalendar));
            Assert.All(result, appointment => Assert.Equal(6, appointment.IdDay));
        }


        [Fact]
        public void TestappointmentInSelectedDate_incorrect()
        {
            DateTime selectedDate = new DateTime(2023, 05, 06);
            int idCalendar = 2;

            List<AppointmentModel> appointments = new List<AppointmentModel>()
            {
            new AppointmentModel 
            { 
                IdTerm = 3,
                IdDay = 4,
                Cost = 1000,
                IsActive = true,
                IdCalendar = 2,
                IdEmployee = 3,
                PatientId = 2,
                IdOffice = 1 },
            new AppointmentModel 
            { 
                IdTerm = 10,
                IdDay = 9,
                Cost = 1000,
                IsActive = true,
                IdCalendar = 1,
                IdEmployee = 3,
                PatientId = 3,
                IdOffice = 1 }
            };

            List<AppointmentModel> result = CalendarAppointmentService.appointmentInSelectedDate(appointments, selectedDate, idCalendar);
            Assert.Empty(result);
        }
        #endregion


        #region GetAppointmentsData
        [Fact]
        public void TestGetAppointmentsData_Correct()
        {
            using (AppDbContext context = new AppDbContext())
            {
                AppointmentModel fourth = fourthFakeAppointment;
                context.DbAppointments.Add(fourth);
                AppointmentModel third = thirdFakeAppointment;
                context.DbAppointments.Add(third);
                context.SaveChanges();

                int Count = context.DbAppointments.Count();

                var result = CalendarAppointmentService.GetAppointmentsData();
                Assert.Equal(Count, result.Count);
                Assert.Contains(result, a => a.IdTerm == 3);
                Assert.Contains(result, a => a.IdTerm == 4);
                Assert.Contains(result, a => a.IdDay == 3);
                Assert.Contains(result, a => a.IdDay == 4);
                Assert.Contains(result, a => a.Cost == 1000);
                Assert.Contains(result, a => a.Cost == 1000);
                Assert.Contains(result, a => a.IsActive == true);
                Assert.Contains(result, a => a.IsActive == true);
                Assert.Contains(result, a => a.IdCalendar == 1);
                Assert.Contains(result, a => a.IdCalendar == 1);
                Assert.Contains(result, a => a.IdEmployee == 3);
                Assert.Contains(result, a => a.IdEmployee == 4);
                Assert.Contains(result, a => a.PatientId == 1);
                Assert.Contains(result, a => a.PatientId == 4);
                Assert.Contains(result, a => a.IdOffice == 1);
                Assert.Contains(result, a => a.IdOffice == 2);

                context.DbAppointments.Remove(fourth);
                context.DbAppointments.Remove(third);
                context.SaveChanges();

            }
        }
    }
    #endregion


}




