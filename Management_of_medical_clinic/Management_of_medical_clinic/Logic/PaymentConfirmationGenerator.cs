using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using Console_Management_of_medical_clinic.Logic.Interfaces;
using Console_Management_of_medical_clinic.Model;
using iText.Kernel.Pdf.Canvas.Draw;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using iText.Kernel.Colors;

namespace Console_Management_of_medical_clinic.Logic
{
	public class PaymentConfirmationGenerator : IPaymentConfirmationGenerator
	{
		// TODO: Sections are not created correctly
		public void GeneratePDFConfirmation(DoctorsDayPlanModel appointment)
		{
			// If an object of DoctorsDayPlanModel doesn't have a patient, it's not an appointment
			if (appointment.Patient == null)
			{
				throw new ArgumentNullException(nameof(appointment.Patient), "Patient is null in given DoctorsDayPlanModel object");
			}

			// TODO: Repair relative paths
			// relative paths
			string pdfFolder = @"C:\Users\swacz\Desktop\Workspace\MedicalClinic\Management_of_medical_clinic\Management_of_medical_clinic\Data\PDF\";
			string logoFolder = @"C:\Users\swacz\Desktop\Workspace\MedicalClinic\Management_of_medical_clinic\GUI_Management_of_medical_clinic\Resources\MC_Logo.png";
			string filename = $"Payment confirmation for {appointment.IdDoctorsDayPlan}-{appointment.IdCalendar}-{appointment.IdDay}-{appointment.IdOfTerm}.pdf";

			// pdf destination
			var pdfWriter = new PdfWriter($"{pdfFolder}{filename}");
			var pdfDocument = new PdfDocument(pdfWriter);
			var document = new Document(pdfDocument);

			// Logo section
			var logo = new Image(ImageDataFactory.Create(logoFolder));
			logo.SetHeight(50);
			logo.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
			document.Add(logo);

			// Title paragraph section
			var paymentConfirmationText = new Paragraph("Payment Confirmation")
				.SetFontSize(18)
				.SetBold()
				.SetTextAlignment(TextAlignment.LEFT);
			document.Add(paymentConfirmationText);

            // TODO: Appointment date and time - translate to actual date and actual hour
            // Appointment details section
            string time = AppointmentService.GetTermByTermId((int)appointment.IdOfTerm);
            DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);

            var detailsSection = new Paragraph()
				.Add(new Text("Visit Details \n").SetBold())
				.Add(new Paragraph($"Date: {date.ToShortDateString()} "))
				.Add(new Paragraph($" Time: {time}"));
			document.Add(detailsSection);

			// Doctor details section
			var doctorSection = new Paragraph()
				.Add(new Text("Doctor Name").SetBold())
				.Add(new Paragraph($": {appointment.EmployeeModel.FirstName} {appointment.EmployeeModel.LastName}"));
			document.Add(doctorSection);

			// Patient details section
			var patientSection = new Paragraph()
				.Add(new Text("Patient Name").SetBold())
				.Add(new Paragraph($": {appointment.Patient.FirstName} {appointment.Patient.LastName}"));
			document.Add(patientSection);

			// line separating cost from other data
			var line = new LineSeparator(new SolidLine());
			document.Add(line);

			// Cost at the bottom
			var costText = new Paragraph($"Cost: {appointment.Cost} ")
				.SetFontSize(14)
				.SetBold()
				.SetTextAlignment(TextAlignment.RIGHT);
			document.Add(costText);


            var currentDate = DateTime.Now;
            var generatedOnText = new Paragraph($"Generated on: {currentDate.ToString()}").SetFontColor(DeviceGray.BLACK).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT);
            document.Add(generatedOnText);

            document.Close();

		}
	}
}
