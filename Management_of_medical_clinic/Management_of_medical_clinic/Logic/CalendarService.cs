using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic.Interfaces;
using Console_Management_of_medical_clinic.Model;

namespace Console_Management_of_medical_clinic.Logic
{
	public class CalendarService : ICalendarFilterSort
	{

        public static void AddCalendar(CalendarModel calendarModel)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.DbCalendars.Add(calendarModel);
                context.SaveChanges();
            }
        }

        public List<CalendarModel> GetAll()
		{
			using (AppDbContext context = new())
			{
				return context.DbCalendars.ToList();
			}
		}

		public List<CalendarModel> Filter(string dateReference, string activityStatus)
		{
			List<CalendarModel> filteredCalendars = GetAll();

			dateReference = dateReference.ToLower().Trim();

			// Filtering by date reference
			// Consider improving it by normalizing input or create a mask for a field where it will be written
			if (!string.IsNullOrEmpty(dateReference))
			{
				filteredCalendars =
					filteredCalendars
					.Where(
						c =>
						c.DateReference.ToLower().Contains(dateReference)
						)
					.ToList();
			}

			// Filtering by an activity status - curenntly it's active or inactive
			// If it changes to some enum values, it should be changed
			if (!string.IsNullOrEmpty(activityStatus))
			{
				if (activityStatus == "Inactive")
				{
					filteredCalendars =
						filteredCalendars
						.Where(
							c =>
							c.Active == false
							)
						.ToList();
				}

				if (activityStatus == "Active")
				{
					filteredCalendars =
						filteredCalendars
						.Where(
							c =>
							c.Active == true
							)
						.ToList();
				}
			}

			return filteredCalendars;
		}

		public List<CalendarModel> Sort(string dateReference, bool IsAscending)
		{
			// dateReference is in format "mm-yyyy" which is not sortable in meaningful way
			// TODO: Consider sorting calendars by year taken from "yyyy" part and then by month taken from "mm" part
			List<CalendarModel> sortedCalendars = GetAll();

			if (IsAscending)
			{
				sortedCalendars =
					sortedCalendars
					.OrderBy(
						c =>
						c.DateReference)
					.ToList();
			}
			else
			{
				sortedCalendars =
					sortedCalendars
					.OrderByDescending(
						c =>
						c.DateReference)
					.ToList();
			}

			return sortedCalendars;
		}
	}
}
