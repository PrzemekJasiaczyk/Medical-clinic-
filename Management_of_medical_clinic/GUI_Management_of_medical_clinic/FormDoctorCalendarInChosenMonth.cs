using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
//using System.Globalization.Extensions;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendarInChosenMonth : Form
    {
        EmployeeModel employee;
        DateTime parsedDate;
        string selectedDate;

        public FormDoctorCalendarInChosenMonth(EmployeeModel employee, string selectedDate)
        {
            InitializeComponent();
            this.employee = employee;
            this.selectedDate = selectedDate;
            DateTime.TryParse(selectedDate, out this.parsedDate);
        }

        List<DoctorsDayPlanModel> displayListInDataGridView = new List<DoctorsDayPlanModel>();
        List<DoctorsDayPlanModel> displayAllDoctorsAppointments = new List<DoctorsDayPlanModel>();

        private void FormDoctorCalendarInChosenMonth_Load(object sender, EventArgs e)
        {
            ReloadActiveForm();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(employee);
            this.Hide();
            formDoctorDashboard.ShowDialog();
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
            /*DoctorsDayPlanModel appointment = (DoctorsDayPlanModel)dataGridViewAppointment.SelectedRows[0].Tag;
            FormRegisterAppointment formRegisterAppointment = new FormRegisterAppointment(employee, appointment);
            this.Hide();
            formRegisterAppointment.ShowDialog();
            this.Close();*/
        }

        private void panelPatient_Click(object sender, EventArgs e)
        {
            SortByPatient(dataGridViewYourAppointment);
        }

        private void labelPatient_Click(object sender, EventArgs e)
        {
            SortByPatient(dataGridViewYourAppointment);
        }

        private void panelTime_Click(object sender, EventArgs e)
        {
            SortByTime(dataGridViewYourAppointment);
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            SortByTime(dataGridViewYourAppointment);
        }
        private void UserControlDay_ControlClicked(object sender, DateTime date)   // Date From UserControlDay
        {
            RemoveRowsInDataGridView();
            UpdateDateInLabel(date);
            displayListInDataGridView.Clear();
            displayAllDoctorsAppointments.Clear();

            string timeTerm;
            /*
            int calendarId = CalendarService.GetIdFromDate(date);
            
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsData();
            List<DoctorsDayPlanModel> selectedAppointments = CalendarAppointmentService.appointmentInSelectedDate(appointments, date, calendarId);

            foreach (DoctorsDayPlanModel appointment in selectedAppointments)
            {
                if (appointment.PatientId == null && appointment.Status == EnumAppointmentStatus.Inactive && employee.IdEmployee == appointment.IdEmployee)
                {
                    AddItemToDataGridView(appointment, dataGridViewYourAppointment);
                    displayListInDataGridView.Add(appointment);
                }
                if (employee.IdEmployee != appointment.IdEmployee && appointment.Status == EnumAppointmentStatus.Free)
                {
                    AddItemToDataGridView(appointment, dataGridViewOtherAppointments);
                    displayAllDoctorsAppointments.Add(appointment);

                }
            }
            */


            int calendarId = CalendarService.GetIdFromDate(date);

            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithOUTPatients();

            foreach (DoctorsDayPlanModel appointment in appointments)
                DisplayDataInDataGridView(appointments, calendarId, date);

        }

        private void DisplayDataInDataGridView(List<DoctorsDayPlanModel> appointments, int calendarId, DateTime selectedDate)
        {
            RemoveRowsInDataGridView();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {

                if (appointment.IdDay == selectedDate.Day && calendarId == appointment.IdCalendar)
                {
                    if (appointment.IdEmployee == employee.IdEmployee)
                    {
                        int index = dataGridViewYourAppointment.Rows.Add(AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString(),
                            OfficeService.GetOfficeById((int)appointment.IdOffice).Number);
                        dataGridViewYourAppointment.Rows[index].Tag = appointment;
                    }
                    else
                    {
                        int index = dataGridViewOtherAppointments.Rows.Add(EmployeeService.GetEmployeeByID((int)appointment.IdEmployee).ToString(),
                            AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString(),
                            OfficeService.GetOfficeById((int)appointment.IdOffice).Number);
                        dataGridViewOtherAppointments.Rows[index].Tag = appointment;
                    }

                }

            }
            dataGridViewYourAppointment.ClearSelection();
            dataGridViewOtherAppointments.ClearSelection();
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

                UserControl userControl = itIsADayOf(day);
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
        private void MarkToday(UserControl userControl, DateTime day)
        {
            if (day.Date == DateTime.Today.Date)
            {
                userControl.BackColor = Color.LightBlue;
            }
        }
        private void MarkPlannedDays(UserControl userControl, DateTime day)
        {
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsData();
            int calendarId = CalendarService.GetCalendarIdByDate(Convert.ToDateTime(selectedDate).ToString("d"));

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == employee.IdEmployee && appointment.IdDay == day.Day
                    && appointment.IdCalendar == calendarId && appointment.Status == EnumAppointmentStatus.New
                    && appointment.PatientId == null)
                {
                    userControl.BackColor = Color.Orange;
                }
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
            labelSelectedDate.Text = date.ToString("d");
            selectedDate = date.ToString("d");
        }

        #endregion

        #region DataGridView
        private void AddItemToDataGridView(DoctorsDayPlanModel appointment, DataGridView dataGrid)
        {
            string timeTerm;
            OfficeModel room;

            timeTerm = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
            room = OfficeService.GetOfficeById(Convert.ToInt32(appointment.IdOffice));
            int idDoctorsDayPlan = (int)appointment.IdDoctorsDayPlan;
            EmployeeModel employee = EmployeeModel.FindEmployee((int)appointment.IdEmployee);
            int index;

            if (dataGrid == dataGridViewYourAppointment)
            {
                index = dataGrid.Rows.Add(timeTerm, room.Number, idDoctorsDayPlan);
                dataGrid.Rows[index].Tag = appointment;
            }
            else
            {
                index = dataGrid.Rows.Add(employee.FirstName + " " + employee.LastName, timeTerm, room.Number, idDoctorsDayPlan);
                dataGrid.Rows[index].Tag = appointment;
            }

        }

        private void RemoveRowsInDataGridView()
        {
            dataGridViewYourAppointment.Rows.Clear();
            dataGridViewOtherAppointments.Rows.Clear();
        }
        #endregion

        #region Sort

        void SortByTime(DataGridView dataGrid)
        {
            List<DoctorsDayPlanModel> result = CalendarAppointmentService.SortByTerm(displayListInDataGridView);
            dataGridViewYourAppointment.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in result)
            {
                AddItemToDataGridView(appointment, dataGrid);
            }
        }

        void SortByDoctor(DataGridView dataGrid)
        {
            List<DoctorsDayPlanModel> result = CalendarAppointmentService.SortByDoctorLastName(displayListInDataGridView);
            dataGridViewYourAppointment.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in result)
            {
                AddItemToDataGridView(appointment, dataGrid);
            }
        }

        void SortByPatient(DataGridView dataGrid)
        {
            List<DoctorsDayPlanModel> result = CalendarAppointmentService.SortByPatientLastName(displayListInDataGridView);
            dataGridViewYourAppointment.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in result)
            {
                AddItemToDataGridView(appointment, dataGrid);
            }
        }
        #endregion
        #region LeftPanel
        private void buttonAcceptCalendar_Click(object sender, EventArgs e)
        {
            FormDoctorCalendarAcceptConfirm formCalendarAcceptConfirm = new FormDoctorCalendarAcceptConfirm(selectedDate.ToString(), employee);
            formCalendarAcceptConfirm.ShowDialog();
            Hide();
            Close();

        }

        private void buttonModifyCalendar_Click(object sender, EventArgs e)
        {
            if (button_modifyAppointment.Visible == false)
            {
                button_acceptAppointments.Visible = true;
                button_cancelAppointment.Visible = true;
                button_modifyAppointment.Visible = true;
                button_createTerm.Visible = true;
                button_createTerm.Enabled = true;
                buttonModifyCalendar.Text = "Cancel modifying";


                /*
                labelDoctor.Visible = true;
                labelRoom1.Visible = true;
                labelTime1.Visible = true;
                dataGridViewOtherAppointments.Visible = true;
                labelDuty.Visible = true;
                panelRoom2.Visible = true;
                panelTime2.Visible = true;
                panelDoctor.Visible = true;
                */
            }
            else
            {
                button_acceptAppointments.Visible = false;
                button_cancelAppointment.Visible = false;
                button_modifyAppointment.Visible = false;
                button_createTerm.Visible = false;
                button_createTerm.Enabled = false;
                buttonModifyCalendar.Text = "Modify calendar";

                /*
                labelDoctor.Visible = false;
                labelRoom1.Visible = false;
                labelTime1.Visible = false;
                dataGridViewOtherAppointments.Visible = false;
                labelDuty.Visible = false;
                panelRoom2.Visible = false;
                panelTime2.Visible = false;
                panelDoctor.Visible = false;
                */
            }
        }

        private void buttonRejectCalendar_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void dataGridViewAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (button_acceptAppointments.Visible == true && dataGridViewYourAppointment.SelectedRows.Count > 0)
            {
                button_acceptAppointments.Enabled = true;
                button_cancelAppointment.Enabled = true;
                button_modifyAppointment.Enabled = true;

            }
            else
            {
                button_acceptAppointments.Enabled = false;
                button_cancelAppointment.Enabled = false;
                button_modifyAppointment.Enabled = false;

            }
            if (dataGridViewYourAppointment.SelectedRows.Count > 1)
            {
                button_modifyAppointment.Enabled = false;
            }
            if (dataGridViewYourAppointment.SelectedRows.Count == 0)
            {
                button_acceptAppointments.Enabled = false;
                button_cancelAppointment.Enabled = false;
                button_modifyAppointment.Enabled = false;
            }

        }
        public List<int> GetSelectedColumnData(int columnIndex)
        {
            List<int> selectedColumnData = new List<int>();

            foreach (DataGridViewCell selectedCell in dataGridViewYourAppointment.SelectedCells)
            {
                if (selectedCell.ColumnIndex == columnIndex)
                {
                    int cellValue = Convert.ToInt32(selectedCell.Value);
                    selectedColumnData.Add(cellValue);
                }
            }
            return selectedColumnData;
        }
        private void ReloadActiveForm()
        {
            DateTime displayMonth_date = Convert.ToDateTime(selectedDate);
            RemoveControlPanels();
            displayDays(displayMonth_date);
            ChangeTitle(displayMonth_date);
        }

        private void button_acceptAppointments_Click(object sender, EventArgs e)
        {
            //maybe it would be go to deleted
            /*List<int> idDoctor = GetSelectedColumnData(3);
            foreach (int id in idDoctor)
            {                
                DoctorsPlanService.ChangeAppointmentStatusToActive(id,employee);
            }
            MessageBox.Show("Chosen appointment(s) are now accepted.");
            DateTime month = Convert.ToDateTime(selectedDate);
            int id_cal = CalendarService.GetIdFromDate(month);

            bool isCalStatusChanged = CalendarService.AreAllTermsAccepted(id_cal,employee);

            if (isCalStatusChanged)
            {
                CalendarService.ChangeCalendarStatusToAccepted(id_cal);
                MessageBox.Show("All appointments are accepted, so automatically changed calendar's status to 'accepted')");
            }
            dataGridViewAppointment.ClearSelection();
            dataGridViewAppointment.Rows.Clear();
            dataGridViewAppointment.Refresh();
            ReloadActiveForm();*/
        }

        private void button_cancelAppointment_Click(object sender, EventArgs e)
        {
            List<int> idDoctor = GetSelectedColumnData(2);
            foreach (int id in idDoctor)
            {
                DoctorsPlanService.ChangeAppointmentStatusToFree(id, employee); //when rejecting, then status is changed to free
            }
            MessageBox.Show("Chosen term(s) are now rejected.");
            DateTime month = Convert.ToDateTime(selectedDate);
            int id_cal = CalendarService.GetIdFromDate(month);

            /*bool isCalStatusChanged = CalendarService.AreAllTermsRejected(id_cal, employee);

            if (isCalStatusChanged)
            {
                CalendarService.ChangeCalendarStatusToRejected(id_cal);
                MessageBox.Show("All appointments are rejected, so automatically changed calendar's status to 'rejected')");
            }*/
            dataGridViewYourAppointment.ClearSelection();
            dataGridViewYourAppointment.Rows.Clear();
            dataGridViewYourAppointment.Refresh();
            dataGridViewOtherAppointments.ClearSelection();
            dataGridViewOtherAppointments.Rows.Clear();
            dataGridViewOtherAppointments.Refresh();
            ReloadActiveForm();


        }

        private void button_modifyAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewYourAppointment.SelectedRows.Count != 1)
                return;

            DoctorsDayPlanModel appointment = (DoctorsDayPlanModel)dataGridViewYourAppointment.SelectedRows[0].Tag;

            FormDoctorCalendarDetails edit = new FormDoctorCalendarDetails(appointment, employee, selectedDate);

            this.Hide();
            edit.ShowDialog();
            this.Close();
        }

        private void button_createTerm_Click(object sender, EventArgs e)
        {
            if (selectedDate.Length != 0)
            {
                FormDoctorCalendarModify formDoctorCalendarModify = new FormDoctorCalendarModify(null, employee, true, /*DateTime.Parse(selectedDate)*/ selectedDate);
                this.Hide();
                formDoctorCalendarModify.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("A term needs to be selected");
            }
        }

        private void flowLayoutPanelMonth_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}