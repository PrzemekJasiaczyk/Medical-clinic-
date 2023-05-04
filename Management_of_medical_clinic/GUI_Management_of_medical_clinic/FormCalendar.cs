using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormCalendar : Form
    {
        EmployeeModel currentEmployee;
        bool previousMonth;
        CalendarModel duplicateCalendar;
        string _selectedDate="";

        public FormCalendar(EmployeeModel currentEmployee, bool previousMonth = false)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            this.previousMonth = previousMonth;
            if (previousMonth)
            {
                this.currentMonth = DateTime.Today;
            }
        }

        public FormCalendar(EmployeeModel currentEmployee, CalendarModel calendarModel)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            duplicateCalendar = calendarModel;

        }

        DateTime displayMonth = DateTime.Today;
        DateTime currentMonth = new DateTime();

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayDays(displayMonth);
            ChangeTitle(displayMonth);

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
            ChangeTitle(displayMonth);
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth = displayMonth.AddMonths(-1);

            displayDays(displayMonth);
            ChangeTitle(displayMonth);
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth = displayMonth.AddMonths(+1);

            displayDays(displayMonth);
            ChangeTitle(displayMonth);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //EmployeeModel employee = EmployeeService.GetEmployeeByUserId(user);
            FormCalendarsList formCalendarsList = new(currentEmployee);
            formCalendarsList.ShowDialog();
            Close();
        }

        #region

        private void RemoveControlPanels()
        {
            flowLayoutPanelMonth.Controls.Clear();
        }

        private void ChangeTitle(DateTime date)
        {
            string year = date.Year.ToString();

            CultureInfo culture = new CultureInfo("en-US");
            string month = date.ToString("MMMM", culture);

            labelTitleCalendar_Month.Text = month.ToUpper();
            labelTitleCalendar_Year.Text = year;
        }



        private void displayDays(DateTime date)
        {

            DateTime startOfTheMonth = new DateTime(date.Year, date.Month, 1);

            int days = DateTime.DaysInMonth(date.Year, date.Month);


            int dayOfWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek);

            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank(null);
                flowLayoutPanelMonth.Controls.Add(userControlBlank);

            }



            for (int i = 1; i <= days; i++)
            {

                DateTime day = new DateTime(date.Year, date.Month, i);

                UserControl userControl = itIsADayOf(day);

                MarkToday(userControl, day);

                flowLayoutPanelMonth.Controls.Add(userControl);

            }

            int completeControls = dayOfWeek + days;

            for (int i = completeControls; i < 42; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank(null);
                flowLayoutPanelMonth.Controls.Add(userControlBlank);
            }


        }

        private void MarkToday(UserControl userControl, DateTime day)
        {
            if (day.Date == DateTime.Today.Date)
            {
                userControl.BackColor = Color.LightBlue;
            }
        }

        private UserControl itIsADayOf(DateTime date)
        {
            //add holidays to calendar --dont work

            //int year = date.Year;
            //string countryCode = "PL";

            //CultureInfo culture = new CultureInfo(countryCode);
            //Calendar calendar = culture.Calendar;

            //DateTime[] holidays = calendar.GetHolidays(year);


            if (date.DayOfWeek != 0)  //|| !holidays.Contains(date)
            {
                UserControlDay userControlDay = new UserControlDay(date, null);
                userControlDay.ControlClicked += UserControlDay_ControlClicked;
                return userControlDay;
            }
            else
            {
                UserControlBlank userControlBlank = new UserControlBlank(date);
                userControlBlank.BackColor = Color.Gainsboro;
                return userControlBlank;
            }
        }

        private void UserControlDay_ControlClicked(object sender, DateTime selectedDate)   // Date From UserControlDay
        {
            CheckTheMonth();
            labelDate.Text = selectedDate.ToString("d");
            _selectedDate= selectedDate.ToString("d");

            List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(selectedDate, duplicateCalendar == null ? 0 : duplicateCalendar.IdCalendar);
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
            if (_selectedDate.Length != 0)
            {
                if (CalendarService.checkIfCalendarExists(_selectedDate) == true)
                {
                    FormAppointmentAdd formAppointmentAdd = new FormAppointmentAdd(DateTime.Parse(labelDate.Text), currentEmployee);
                    //this.Hide();
                    formAppointmentAdd.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("A calendar hasn't been started for the given month");
                }
            }
            else
            {
                MessageBox.Show("A term needs to be selected");
            }

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

        private void CheckTheMonth()
        {
            if (displayMonth.Month == currentMonth.Month)
            {
                previousMonth = true;
                return;

            }
            previousMonth = false;
        }
    }
}