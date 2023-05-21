using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Data.Enums;

namespace MedicalClinicTest
{
	public class PaymentConfirmationGeneratorTest
	{
		[Fact]
		public void GeneratePDFConfirmation_AllCorrect()
		{
			var generator = new PaymentConfirmationGenerator();
			var appointment = new DoctorsDayPlanModel
			{
				IdDoctorsDayPlan = 1,
				IdCalendar = 1,
				IdDay = 1,
				IdOfTerm = 1,
				Status = EnumAppointmentStatus.Accepted,
				Cost = 100,
				EmployeeModel = new EmployeeModel()
				{
					FirstName = "Jan",
					LastName = "Brzechwa"
				},
				Patient = new Patient()
				{
					FirstName = "Adam",
					LastName = "Imbirek"
				}
			};

			// TODO: Repair relative paths
			string pdfFolder = @"C:\Users\micha\Documents\Projekty\CSharp\Klinika\TO_registration_gr3\Management_of_medical_clinic\Management_of_medical_clinic\Data\PDF\";
			string filename = $"Payment confirmation for {appointment.IdDoctorsDayPlan}-{appointment.IdCalendar}-{appointment.IdDay}-{appointment.IdOfTerm}.pdf";
			string pdfFilePath = Path.Combine(pdfFolder, filename);

			generator.GeneratePDFConfirmation(appointment);

			Assert.True(File.Exists(pdfFilePath), "File wasn't created correctly");

			File.Delete(pdfFilePath);
		}
	}
}
