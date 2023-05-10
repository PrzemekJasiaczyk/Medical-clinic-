using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;

namespace MedicalClinicTest
{
	public class CalendarServiceTest
	{
		[Fact]
		public void SortAscending_Correct()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", true);

			Assert.StartsWith("03", sortedCalendars[0].DateReference);
		}

		[Fact]
		public void SortDescending_Correct()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", false);

			Assert.StartsWith("05", sortedCalendars[0].DateReference);
		}

		[Fact]
		public void SortAscending_Incorrect()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", true);

			bool incorrectFirstMonth = sortedCalendars[0].DateReference.StartsWith("05");
			Assert.False(incorrectFirstMonth);
		}

		[Fact]
		public void SortDescending_Incorrect()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", false);

			bool incorrectFirstMonth = sortedCalendars[0].DateReference.StartsWith("03");
			Assert.False(incorrectFirstMonth);
		}

		[Fact]
		public void Filter_Correct()
		{

		}

		[Fact]
		public void Filter_Incorrect() 
		{

		}
	}
}
