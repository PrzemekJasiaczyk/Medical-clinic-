using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormCalendarsList : Form
    {
        EmployeeModel currentUser;
        CalendarService _calendarService = new();
        List<string> statusList = new List<string>()
        { "Active", "Inactive", "" };

        public FormCalendarsList(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            dataGridViewCalendars.DataSource = _calendarService.GetAll();
            comboBoxStatus.DataSource = statusList;
            comboBoxStatus.SelectedIndex = 2;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            Hide();
            menu.ShowDialog();
            Close();
        }


        private void buttonDuplicateCalendar_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new FormCalendar(currentUser, CalendarService.GetCalendarById((int)dataGridViewCalendars.CurrentRow.Cells[0].Value));
            formCalendar.ShowDialog();
            Close();
        }


        private void buttonEditCalendar_Click(object sender, EventArgs e)
        {
            // TODO: Open edit clicked calendar form
        }

        private void buttonRemoveCalendar_Click(object sender, EventArgs e)
        {
            // TODO: Open a window with a confirmation if someone really wants to delete selected calendar
            try
            {
                int calendarId = int.Parse(dataGridViewCalendars.CurrentRow.Cells[0].Value.ToString());

                FormCalendarDelete formCalendarDelete = new FormCalendarDelete(calendarId);
                formCalendarDelete.ShowDialog();
                dataGridViewCalendars.DataSource = null;
                dataGridViewCalendars.DataSource = _calendarService.GetAll();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterCalendars_Click(object sender, EventArgs e)
        {
            dataGridViewCalendars.DataSource = _calendarService.Filter(textBoxDateReference.Text, (string)comboBoxStatus.SelectedValue);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new(currentUser);
            formCalendar.ShowDialog();
            Close();
        }

        private void FormCalendarsList_Load(object sender, EventArgs e)
        {

        }
    }
}
