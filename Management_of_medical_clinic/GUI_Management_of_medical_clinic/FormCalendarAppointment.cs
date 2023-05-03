using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System.Globalization;
using System.Numerics;
//using System.Globalization.Extensions;


namespace GUI_Management_of_medical_clinic
{
    public partial class FormCalendarAppointment : Form
    {
        EmployeeModel employee;


        public FormCalendarAppointment(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
        }


        DateTime displayMonth_date = DateTime.Today;
        List<AppointmentModel> displayListInDataGridView = new List<AppointmentModel>();


        private void FormCalendarAppointment_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayDays(displayMonth_date);
            ChangeTitle(displayMonth_date);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayMonth_date = DateTime.Now;
            displayDays(displayMonth_date);
            ChangeTitle(displayMonth_date);
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth_date = displayMonth_date.AddMonths(-1);

            displayDays(displayMonth_date);
            ChangeTitle(displayMonth_date);
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth_date = displayMonth_date.AddMonths(+1);

            displayDays(displayMonth_date);
            ChangeTitle(displayMonth_date);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormPatientList formPatientList = new FormPatientList(employee);
            this.Hide();
            formPatientList.ShowDialog();
            this.Close();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            FormRegisterAppointment formRegisterAppointment = new FormRegisterAppointment(employee, null);
            this.Hide();
            formRegisterAppointment.ShowDialog();
            this.Close();

        }

        private void buttonDisplayAppointments_Click(object sender, EventArgs e)
        {
            FormListAppointment formListAppointment = new FormListAppointment(employee);
            this.Hide();
            formListAppointment.ShowDialog();
            this.Close();
        }

        private void dataGridViewAppointment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AppointmentModel appointment = (AppointmentModel)dataGridViewAppointment.SelectedRows[0].Tag;
            FormRegisterAppointment formRegisterAppointment = new FormRegisterAppointment(employee, appointment);
            this.Hide();
            formRegisterAppointment.ShowDialog();
            this.Close();
        }

        private void panelDoctor_Click(object sender, EventArgs e)
        {
            SortByDoctor();
        }

        private void labelDoctor_Click(object sender, EventArgs e)
        {
            SortByDoctor();
        }

        private void panelTime_Click(object sender, EventArgs e)
        {
            SortByTime();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            SortByTime();
        }

        private void UserControlDay_ControlClicked(object sender, DateTime date)   // Date From UserControlDay
        {
            RemoveRowsInDataGridView();
            UpdateDateInLabel(date);
            displayListInDataGridView.Clear();

            string timeTerm;
            string doctor;
            int calendarId = CalendarService.GetIdFromDate(date);

            List<AppointmentModel> appointments = CalendarAppointmentService.GetAppointmentsData();
            List<AppointmentModel> selectedAppointments = CalendarAppointmentService.appointmentInSelectedDate(appointments, date, calendarId);

            foreach (AppointmentModel appointment in selectedAppointments)
            {
                if (appointment.PatientId == null && appointment.IsActive == true)
                {
                    AddItemToDataGridView(appointment);
                    displayListInDataGridView.Add(appointment);
                }
            }
        }


        #region Calendar

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

                // userControlDay.ControlClicked += UserControlDay_ControlClicked;

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

        private void UpdateDateInLabel(DateTime date)
        {
            labelSelectedDate.Text = "Selected date: " + date.ToShortDateString();
        }

        #endregion

        #region DataGridView
        private void AddItemToDataGridView(AppointmentModel appointment)
        {
            string timeTerm;
            string doctor;

            timeTerm = AppointmentService.GetTermByTermId(appointment.IdTerm);
            doctor = CalendarAppointmentService.GetLastNameAndNameOfEmployeeByAppointment(appointment);

            int index = dataGridViewAppointment.Rows.Add(doctor, timeTerm);
            dataGridViewAppointment.Rows[index].Tag = appointment;

        }

        private void RemoveRowsInDataGridView()
        {
            dataGridViewAppointment.Rows.Clear();
        }
        #endregion

        #region Sort

        void SortByTime()
        {
            List<AppointmentModel> result = CalendarAppointmentService.SortByTerm(displayListInDataGridView);
            dataGridViewAppointment.Rows.Clear();

            foreach (AppointmentModel appointment in result)
            {
                AddItemToDataGridView(appointment);
            }
        }

        void SortByDoctor()
        {
            List<AppointmentModel> result = CalendarAppointmentService.SortByDoctor(displayListInDataGridView);
            dataGridViewAppointment.Rows.Clear();

            foreach (AppointmentModel appointment in result)
            {
                AddItemToDataGridView(appointment);
            }
        }

        #endregion


    }
}