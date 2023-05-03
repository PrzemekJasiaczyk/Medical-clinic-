using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendar : Form
    {
        EmployeeModel currentEmployee;
        bool previousMonth;
        public FormDoctorCalendar(EmployeeModel currentEmployee, bool previousMonth = false)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            this.previousMonth = previousMonth;
        }

        DateTime displayMonth = DateTime.Today;

        private void FormDoctorCalendar_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            CalendarService calendarService = new CalendarService();
            List<CalendarModel> calendars = calendarService.GetAll();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentEmployee.IdEmployee)
                {
                    displayMonth = Convert.ToDateTime(calendar.DateReference);
                }
            }



            //displayMonth = previousMonth ? displayMonth.AddMonths(-1) : displayMonth;
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
                UserControlDay userControlDay = new UserControlDay(date,null);
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
        
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentEmployee);
            formDoctorDashboard.ShowDialog();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}