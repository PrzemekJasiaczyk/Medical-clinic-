using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FormCalendar : Form
    {
        EmployeeModel currentEmployee;
        bool previousMonth;
        public FormCalendar(EmployeeModel currentEmployee, bool previousMonth = false)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            this.previousMonth = previousMonth;
        }

        DateTime displayMonth = DateTime.Today;


        private void FormCalendar_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayMonth = previousMonth ? displayMonth.AddMonths(-1) : displayMonth;
            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);

            dataGridViewAppointments.Rows.Clear();
            dataGridViewAppointments.Columns.Add("Doctor", "Doctor");
            dataGridViewAppointments.Columns.Add("Day", "Day");
            dataGridViewAppointments.Columns.Add("Hour", "Hour");
            dataGridViewAppointments.Columns.Add("Patient", "Patient");

        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayMonth = DateTime.Now;
            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth = displayMonth.AddMonths(-1);

            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth = displayMonth.AddMonths(+1);

            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.ShowDialog();
            this.Close();
        }

        #region

        private void RemoveControlPanels()
        {
            flowLayoutPanelMonth.Controls.Clear();
        }

        private void ChangeTitle(Label label, DateTime date)
        {
            string year = date.Year.ToString();
            string month = date.ToString("MMMM");

            label.Text = year + " - " + month;
        }



        private void displayDays(DateTime date)
        {
            // bierzemy pierwszy dzieñ miesi¹ca
            DateTime startOfTheMonth = new DateTime(date.Year, date.Month, 1);

            // liczymy iloœæ dni w miesi¹cu aby wiedzieæ ile paneli trzeba pokazaæ
            int days = DateTime.DaysInMonth(date.Year, date.Month);


            // konwertujemy startOfTheMonth na int, dzieñ tygodnia
            // -- w którym miejscu panel ma siê pojawiæ, jak 3 to œroda itp
            int dayOfWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek);

            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                flowLayoutPanelMonth.Controls.Add(userControlBlank);

            }



            for (int i = 1; i <= days; i++)
            {

                DateTime day = new DateTime(date.Year, date.Month, i);

                UserControlDay userControlDay = new UserControlDay(day);

                userControlDay.ControlClicked += UserControlDay_ControlClicked;

                bool isSunday = day.DayOfWeek == DayOfWeek.Sunday;
                if (isSunday)
                {
                    userControlDay.BackColor = Color.DarkGray;
                }

                

                flowLayoutPanelMonth.Controls.Add(userControlDay);
            }

            // liczymy ile trzeba dodaæ pustych paneli,aby uzupe³niæ kalendarz
            int completeControls = dayOfWeek + days;

            for (int i = completeControls; i < 42; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                
                flowLayoutPanelMonth.Controls.Add(userControlBlank);
            }


        }

        private void UserControlDay_ControlClicked(object sender, DateTime selectedDate)   // Date From UserControlDay
        {
            labelDate.Text = selectedDate.ToString("d");

            List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(selectedDate);
            dataGridViewAppointments.Rows.Clear();
            foreach (AppointmentModel appointment in appointments)
            {
                string timeTerm = AppointmentService.GetTermByTermId(appointment.IdTerm);
                Patient patient = PatientService.GetPatientById((int)appointment.PatientId);
                dataGridViewAppointments.Rows.Add(appointment.IdEmployee, appointment.IdDay, timeTerm, patient.FirstName + " " + patient.LastName);
            }
        }


        #endregion


        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            if (labelDate.Text == "Select term") { MessageBox.Show("Choose term"); return; }

            FormAppointmentAdd formAppointmentAdd = new FormAppointmentAdd(DateTime.Parse(labelDate.Text), currentEmployee);
            //this.Hide();
            formAppointmentAdd.ShowDialog();
            //this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void createCalendarButton_Click(object sender, EventArgs e)
        {
            string month = displayMonth.ToString("MM");
            string year = displayMonth.ToString("yyyy");
            string monthAndYear = month + "-" + year;
            CalendarModel calendarModel = new CalendarModel(monthAndYear, false);
            CalendarService.AddCalendar(calendarModel);
            MessageBox.Show("Calendar added");
            FormCalendarsList formCalendarsList = new FormCalendarsList(currentEmployee);
            formCalendarsList.ShowDialog();
            Close();
        }
    }
}