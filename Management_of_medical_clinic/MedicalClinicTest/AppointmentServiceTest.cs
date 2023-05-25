using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalClinicTest
{
	public class AppointmentServiceTest
	{
		[Fact]
		public void CanRescheduleAppointment_Correct()
		{
			bool canReschedule;
			string errorMessage;

			using AppDbContext context = new();

			DoctorsDayPlanModel appointment = context.DbDoctorsDayPlan.Find(20);
			appointment.IdDay = DateTime.Today.Day;

			DoctorsDayPlanModel term = context.DbDoctorsDayPlan.Find(21);
			term.IdDay = DateTime.Today.Day + 1;
			term.PatientId = null;

			AppointmentService appointmentService = new();
			(canReschedule, errorMessage) = appointmentService.CanReschedule(appointment, term);

			Assert.True(canReschedule);
			Assert.Equal("Appointment rescheduled succesfully", errorMessage);
		}

		[Fact]
		public void CanRescheduleAppointment_Taken()
		{
			bool canReschedule;
			string errorMessage;

			using AppDbContext context = new();
			DoctorsDayPlanModel appointment = context.DbDoctorsDayPlan.Find(19);
			DoctorsDayPlanModel term = context.DbDoctorsDayPlan.Find(20);

			AppointmentService appointmentService = new();
			(canReschedule, errorMessage) = appointmentService.CanReschedule(appointment, term);

			Assert.False(canReschedule);
			Assert.Equal("The term to reschedule appointment is already taken", errorMessage);
		}

		[Fact]
		public void CanRescheduleAppointment_PastDay()
		{
			bool canReschedule;
			string errorMessage;

			using AppDbContext context = new();
			DoctorsDayPlanModel appointment = context.DbDoctorsDayPlan.Find(23);
			DoctorsDayPlanModel term = context.DbDoctorsDayPlan.Find(21);

			AppointmentService appointmentService = new();
			(canReschedule, errorMessage) = appointmentService.CanReschedule(appointment, term);

			Assert.False(canReschedule);
			Assert.Equal("The appointment cannot be rescheduled to the past", errorMessage);
		}

		// TODO: Dodaj rekord, który pozwala to przetestować
		[Fact]
		public void CanRescheduleAppointment_PastHour()
		{
			bool canReschedule;
			string errorMessage;

			using AppDbContext context = new();
			DoctorsDayPlanModel appointment = context.DbDoctorsDayPlan.Find(15);
			DoctorsDayPlanModel term = context.DbDoctorsDayPlan.Find(17);

			AppointmentService appointmentService = new();
			(canReschedule, errorMessage) = appointmentService.CanReschedule(appointment, term);

			Assert.False(canReschedule);
			Assert.Equal("The appointment cannot be rescheduled to the past", errorMessage);
		}
	}
}
