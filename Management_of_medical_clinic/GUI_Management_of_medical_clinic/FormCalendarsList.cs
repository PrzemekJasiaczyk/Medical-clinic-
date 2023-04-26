using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;

namespace GUI_Management_of_medical_clinic
{
	public partial class FormCalendarsList : Form
	{
		EmployeeModel currentUser;
		CalendarService _calendarService = new();

		public FormCalendarsList()
		{
			InitializeComponent();
			dataGridViewCalendars.DataSource = _calendarService.GetAll();
			comboBoxStatus.DataSource = ("Active", "Inactive", "");
		}

		public FormCalendarsList(EmployeeModel currentUser)
		{
			this.currentUser = currentUser;
			InitializeComponent();
		}

		private void buttonLogOut_Click(object sender, EventArgs e)
		{
			FormMenu menu = new FormMenu();
			menu.ShowDialog();
			Close();
		}

		private void buttonAddCalendar_Click(object sender, EventArgs e)
		{
			// TODO: Open create new calendar form
		}

		private void buttonEditCalendar_Click(object sender, EventArgs e)
		{
			// TODO: Open edit clicked calendar form
		}

		private void buttonRemoveCalendar_Click(object sender, EventArgs e)
		{
			// TODO: Open a window with a confirmation if someone really wants to delete selected calendar
		}

		private void buttonFilterCalendars_Click(object sender, EventArgs e)
		{
			dataGridViewCalendars.DataSource = _calendarService.Filter(textBoxDateReference.Text, comboBoxStatus.SelectedText);
		}

		private void buttonClearFilter_Click(object sender, EventArgs e)
		{
			dataGridViewCalendars.DataSource = _calendarService.GetAll();
		}

		private void buttonSortAscending_Click(object sender, EventArgs e)
		{
			dataGridViewCalendars.DataSource = _calendarService.Sort(textBoxDateReference.Text, true);
		}

		private void buttonSortDescending_Click(object sender, EventArgs e)
		{
			dataGridViewCalendars.DataSource = _calendarService.Sort(textBoxDateReference.Text, false);
		}
	}
}
