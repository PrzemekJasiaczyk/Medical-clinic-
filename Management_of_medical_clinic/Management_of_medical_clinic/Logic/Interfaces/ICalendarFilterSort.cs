using Console_Management_of_medical_clinic.Model;

namespace Console_Management_of_medical_clinic.Logic.Interfaces
{
	public interface ICalendarFilterSort
    {
		// TODO: Odkomentować i podmienić nazwy gdy będzie gotowe.
		public List<CalendarModel> GetAll();

		public List<CalendarModel> Filter(string dateReference, string activityStatus);

		public List<CalendarModel> Sort(string propertyName, bool IsAscending);
	}
}
