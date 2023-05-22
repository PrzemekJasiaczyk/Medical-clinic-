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

        List<DoctorsDayPlanModel> displayListInDataGridView = new List<DoctorsDayPlanModel>();
        private void RemoveControlPanels()
        {
            flowLayoutPanelMonth.Controls.Clear();
        }

        private void FormDoctorCalendar_Load_1(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayDays(displayMonth);
            ChangeTitle(displayMonth);


            List<CalendarModel> calendars = CalendarService.GetCalendarData();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentUser.IdEmployee && calendar.Active == false)
                {
                    displayMonth = Convert.ToDateTime(calendar.DateReference);
                    this.calendar = calendar;
                }
            }

            dataGridViewAppointments.Rows.Clear();
            dataGridViewAppointments.Columns.Add("Doctor", "Doctor");
            dataGridViewAppointments.Columns.Add("Room", "Room");
            dataGridViewAppointments.Columns.Add("Hour", "Hour");
            dataGridViewAppointments.Columns.Add("Patient", "Patient");

            dataGridViewYourAppointments.Rows.Clear();
            dataGridViewYourAppointments.Columns.Add("Room", "Room");
            dataGridViewYourAppointments.Columns.Add("Hour", "Hour");
            dataGridViewYourAppointments.Columns.Add("Patient", "Patient");
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

                UserControl userControl = createControls(day);
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

        private void MarkToday(UserControl userControl, DateTime day)
        {
            if (day.Date == DateTime.Today.Date)
            {
                userControl.BackColor = Color.LightBlue;
            }
        }
        private void MarkPlannedDays(UserControl userControl, DateTime day)
        {
            List<DoctorsDayPlanModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(day);
            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee)
                {
                    userControl.BackColor = Color.Orange;
                }
            }
        }
        private UserControl createControls(DateTime date)
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



        private void UserControlDay_ControlClicked(object sender, DateTime selectedDate)
        {
            UpdatelabelDate(selectedDate);

            List<DoctorsDayPlanModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(selectedDate);

            dataGridViewAppointments.Rows.Clear();
            dataGridViewYourAppointments.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                string timeTerm = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
                //Patient patient = PatientService.GetPatientById((int)appointment.PatientId);

                if (appointment.IdEmployee == currentUser.IdEmployee)
                {
                    int index = dataGridViewYourAppointments.Rows.Add(appointment.IdOffice, timeTerm, /*patient.FirstName +*/" " /*+ patient.LastName*/);
                    dataGridViewYourAppointments.Rows[index].Tag = appointment;
                }

                dataGridViewAppointments.Rows.Add(appointment.IdEmployee, appointment.IdOffice, timeTerm, /*patient.FirstName +*/" " /*+ patient.LastName*/);

            }
        }

        private void UpdatelabelDate(DateTime date)
        {
            labelDate.Text = date.ToString("d");
        }
        private void buttonAccept_Click(object sender, EventArgs e) //accept calendar
        {
            FormCalendarAcceptConfirm formCalendarAcceptConfirm = new FormCalendarAcceptConfirm(calendar);
            formCalendarAcceptConfirm.ShowDialog();
            this.Hide();
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            formDoctorDashboard.ShowDialog();

        }

        private void buttonReject_Click(object sender, EventArgs e) //reject calendar
        {
            
            FormCalendarRejectConfirm formCalendarRejectConfirm = new FormCalendarRejectConfirm(calendar);
            formCalendarRejectConfirm.ShowDialog();
            this.Hide();
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            formDoctorDashboard.ShowDialog();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            formDoctorDashboard.ShowDialog();
            this.Close();
        }

        private void buttonEditAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewYourAppointments.SelectedRows.Count != 1)
                return;

            AppointmentModel appointment = (AppointmentModel)dataGridViewYourAppointments.SelectedRows[0].Tag;

            FormDoctorCalendarDetails edit = new FormDoctorCalendarDetails(appointment, currentUser);

            this.Hide();
            edit.ShowDialog();
            this.Close();
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth = displayMonth.AddMonths(+1);

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
    }
}