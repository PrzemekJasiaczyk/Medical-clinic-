using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
        string _selectedDate = "";
        public FormDoctorCalendar(EmployeeModel currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        //nie today tylko pierwszy do akceptacji 
        DateTime displayMonth = DateTime.Today;



        List<DoctorsDayPlanModel> displayListInDataGridView = new List<DoctorsDayPlanModel>();

        private void FormDoctorCalendar_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayDays(displayMonth);
            ChangeTitle(displayMonth);

            /*
            List<CalendarModel> calendars = CalendarService.GetCalendarData();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentUser.IdEmployee && calendar.Active == false)
                {
                    displayMonth = Convert.ToDateTime(calendar.DateReference);
                    this.calendar = calendar;
                }
            }
            */
            dataGridViewAppointments.Rows.Clear();
            dataGridViewAppointments.Columns.Add("Doctor", "Doctor");
            dataGridViewAppointments.Columns.Add("Room", "Room");
            dataGridViewAppointments.Columns.Add("Hour", "Hour");

            dataGridViewYourAppointments.Rows.Clear();
            dataGridViewYourAppointments.Columns.Add("Doctor", "Doctor");
            dataGridViewYourAppointments.Columns.Add("Room", "Room");
            dataGridViewYourAppointments.Columns.Add("Hour", "Hour");
        }
        #region Calendar
        private void ChangeTitle(DateTime date)
        {
            string year = date.Year.ToString();

            CultureInfo culture = new CultureInfo("en-US");
            string month = date.ToString("MMMM", culture);

            labelTitleCalendar_Month.Text = month.ToUpper();
            labelTitleCalendar_Year.Text = year;
            //Sprawdzanie statusu kalendarza
            //labelCalendarStatus.Text = 
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

        private void RemoveControlPanels()
        {
            flowLayoutPanelMonth.Controls.Clear();
        }
        #endregion
        private void MarkToday(UserControl userControl, DateTime day)
        {
            if (day.Date == DateTime.Today.Date)
            {
                userControl.BackColor = Color.LightBlue;
            }
        }
        private void MarkPlannedDays(UserControl userControl, DateTime day)
        {
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();

            int calendarId = CalendarService.GetIdFromDate(day);

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee && appointment.IdDay == day.Day && calendarId == appointment.IdCalendar)
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
            RemoveRowsInDataGridView();
            UpdateDateInLabel(selectedDate);
            displayListInDataGridView.Clear();

            int calendarId = CalendarService.GetIdFromDate(selectedDate);

            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();//do poprawy
            //List<DoctorsDayPlanModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(selectedDate);

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (true)
                {
                    DisplayDataInDataGridView(appointments, calendarId, selectedDate);
                }
            }

        }
        #region DataGridView
        private void DisplayDataInDataGridView(List<DoctorsDayPlanModel> appointments, int calendarId, DateTime selectedDate)
        {
            RemoveRowsInDataGridView();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {

                if (appointment.IdDay == selectedDate.Day && calendarId == appointment.IdCalendar)
                {
                    if (appointment.IdEmployee == currentUser.IdEmployee)
                    {
                        int index = dataGridViewYourAppointments.Rows.Add(EmployeeService.GetEmployeeByID((int)appointment.IdEmployee).ToString(),
                            OfficeService.GetOfficeById((int)appointment.IdOffice).Number,
                            AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString());
                        dataGridViewYourAppointments.Rows[index].Tag = appointment;
                    }
                    else
                    {
                        int index = dataGridViewAppointments.Rows.Add(EmployeeService.GetEmployeeByID((int)appointment.IdEmployee).ToString(),
                            OfficeService.GetOfficeById((int)appointment.IdOffice).Number,
                            AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString());
                        dataGridViewAppointments.Rows[index].Tag = appointment;
                        /*
                        int index = dataGridViewAppointments.Rows.Add(OfficeService.GetOfficeById((int)appointment.IdOffice).Number,
                        AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString(),
                        PatientService.GetPatientById((int)appointment.PatientId).ToString());
                        dataGridViewAppointments.Rows[index].Tag = appointment;*/
                    }

                }

            }
        }
        private void RemoveRowsInDataGridView()
        {
            dataGridViewYourAppointments.Rows.Clear();
            dataGridViewAppointments.Rows.Clear();
        }

        #endregion
        private void UpdateDateInLabel(DateTime date)
        {
            labelDate.Text = date.ToString("d");
            _selectedDate = date.ToString("d");
        }


        private void buttonAccept_Click(object sender, EventArgs e) //accept calendar 
        {
            //
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

            DoctorsDayPlanModel appointment = (DoctorsDayPlanModel)dataGridViewYourAppointments.SelectedRows[0].Tag;

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

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            if (_selectedDate.Length != 0)
            {
                FormDoctorCalendarModify formDoctorCalendarModify = new FormDoctorCalendarModify(null, currentUser, true, DateTime.Parse(labelDate.Text));
                this.Hide();
                formDoctorCalendarModify.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("A term needs to be selected");
            }
        }

    }
}