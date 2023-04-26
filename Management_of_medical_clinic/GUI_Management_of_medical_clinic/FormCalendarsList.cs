using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
	}
}
