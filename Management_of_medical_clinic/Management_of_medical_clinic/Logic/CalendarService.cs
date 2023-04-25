using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic.Interfaces;
using Console_Management_of_medical_clinic.Model;

namespace Console_Management_of_medical_clinic.Logic
{
	public class CalendarService : ICalendarFilterSort
	{
		// TODO: Odkomentować i podmienić nazwy gdy będzie gotowe.
		public List<CalendarModel> GetAll()
		{
			using (AppDbContext context = new())
			{
				return context.DbCalendars.ToList();
			}
		}

		//public List<CalendarModel> Filter(List<CalendarModel> calendars, string calendarName)
		//{
		//	return calendars
		//		.Where(c => c.CalendarModelTime == calendarName)
		//		.ToList();
		//}

		//public List<CalendarModel> Filter(List<CalendarModel> calendars, CalendarStatus status)
		//{
		//	return calendars
		//		.Where(c => c.CalendarStatus == status)
		//		.ToList();
		//}

		//public List<CalendarModel> Filter(List<CalendarModel> calendars, string calendarName, CalendarStatus status)
		//{
		//	return calendars
		//		.Where(c => (c.CalendarStatus == status && c.CalendarModelTime == calendarName))
		//		.ToList();
		//}

		//public List<CalendarModel> Sort(List<CalendarModel> calendars, string propertyName, bool IsAscending = true)
		//{
		//	var propertyInfo = typeof(CalendarModel).GetProperty(propertyName);

		//	if (propertyInfo == null)
		//	{
		//		throw new ArgumentException($"Invalid property name '{propertyName}'");
		//	}

		//	// Żeby posortować po CalendarStatus rosnąco trzeba dać:
		//	// calendarService.Sort(listaKalendarzy, CalendarStatus)
		//	// Żeby posortować po ID malejaco trzeba dać:
		//	// calendarService.Sort(listaKalendarzy, CalendarModelId, false)
		//	if (IsAscending)
		//	{
		//		return calendars
		//			.OrderBy(c => propertyInfo.GetValue(c, null))
		//			.ToList();
		//	}
		//	else
		//	{
		//		return calendars
		//			.OrderByDescending(c => propertyInfo.GetValue(c, null))
		//			.ToList();
		//	}
		//}

	}
}
