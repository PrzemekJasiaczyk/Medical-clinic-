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
        EmployeeModel currentUser;
        CalendarModel calendar;
        public FormDoctorCalendar(EmployeeModel currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        DateTime displayMonth = DateTime.Today;

        private void FormDoctorCalendar_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            List<CalendarModel> calendars = new List<CalendarModel>();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentUser.IdEmployee && calendar.Active == false)
                {
                    displayMonth = Convert.ToDateTime(calendar.DateReference);
                    this.calendar = calendar;
                }
            }        

            displayDays(displayMonth);
            ChangeTitle(displayMonth);

            dataGridViewAppointments.Rows.Clear();
            dataGridViewAppointments.Columns.Add("Room", "Room");
            dataGridViewAppointments.Columns.Add("Hour", "Hour");
            dataGridViewAppointments.Columns.Add("Patient", "Patient");
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
                MarkPlannedDays(userControl, day);            
                flowLayoutPanelMonth.Controls.Add(userControl);
            }

            int completeControls = dayOfWeek + days;

            for (int i = completeControls; i < 42; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank(null);
                flowLayoutPanelMonth.Controls.Add(userControlBlank);
            }
        }
        private void MarkPlannedDays(UserControl userControl, DateTime day)
        {
            List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(day);
            foreach (AppointmentModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee)
                {
                    userControl.BackColor = Color.Orange;
                }
            }
        }
        private UserControl itIsADayOf(DateTime date)
        {

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
            labelDate.Text = selectedDate.ToString("d");

            List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(selectedDate);
            dataGridViewAppointments.Rows.Clear();
            foreach (AppointmentModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee)
                {
                    string timeTerm = AppointmentService.GetTermByTermId(appointment.IdTerm);
                    Patient patient = PatientService.GetPatientById((int)appointment.PatientId);
                    dataGridViewAppointments.Rows.Add(appointment.IdOffice, timeTerm, patient.FirstName + " " + patient.LastName);
                }
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            formDoctorDashboard.ShowDialog();
            this.Close();
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            //soon..
        }

        private void buttonAccept_Click(object sender, EventArgs e) //accept calendar
        {
            this.Hide();
            FormCalendarAcceptConfirm formCalendarAcceptConfirm = new FormCalendarAcceptConfirm(calendar);
            formCalendarAcceptConfirm.ShowDialog();
            this.Close();
        }

        private void buttonReject_Click(object sender, EventArgs e) //reject calendar
        {
            this.Hide();
            FormCalendarRejectConfirm formCalendarRejectConfirm = new FormCalendarRejectConfirm(calendar);
            formCalendarRejectConfirm.ShowDialog();
            this.Close();
        }
    }
}