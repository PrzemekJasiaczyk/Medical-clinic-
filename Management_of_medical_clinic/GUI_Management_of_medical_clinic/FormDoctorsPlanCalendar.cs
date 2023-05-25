using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorsPlanCalendar : Form
    {
        EmployeeModel currentEmployee;
        bool previousMonth;
        CalendarModel duplicateCalendar;
        string _selectedDate = "";
        DateTime displayMonth = DateTime.Today;

        public FormDoctorsPlanCalendar(EmployeeModel currentEmployee, bool previousMonth = false)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            this.previousMonth = previousMonth;
            if (previousMonth)
            {
                this.currentMonth = DateTime.Today;
            }

            displayMonth = DateTime.Today;
        }

        public FormDoctorsPlanCalendar(EmployeeModel currentEmployee, CalendarModel calendarModel)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            duplicateCalendar = calendarModel;

            button2.Visible = false;
            button3.Visible = false;

            displayMonth = DateTime.Today.AddMonths(1);

            createCalendarButton.Click -= createCalendarButton_Click;
            createCalendarButton.Click += duplicateCalendar_Click;

        }

        public FormDoctorsPlanCalendar(EmployeeModel currentEmployee, int calendarIdToReview)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;

            string[] dateParts = CalendarService.GetCalendarById(calendarIdToReview).DateReference.Split('-');
            displayMonth = new DateTime(int.Parse(dateParts[1]), int.Parse(dateParts[0]), 1);

            button2.Visible = false;
            button3.Visible = false;

            createCalendarButton.Text = "Edit Calendar";
            createCalendarButton.Click -= createCalendarButton_Click;
            createCalendarButton.Click += editCalendar_Click;

        }

        private void CreateCalendarButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


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

            FormCalendarsList formCalendarsList = new FormCalendarsList(currentEmployee);
            this.Hide();
            formCalendarsList.ShowDialog();
            this.Close();

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

            int year = date.Year;
            string countryCode = "PL";

            CultureInfo culture = new CultureInfo(countryCode);
            Calendar calendar = culture.Calendar;

            DateTime[] holidays = new DateTime[] {
                new DateTime(2023, 1, 1),  // Nowy Rok
                new DateTime(2023, 1, 6),  // �wi�to Trzech Kr�li
                new DateTime(2023, 4, 17), // Poniedzia�ek Wielkanocny
                new DateTime(2023, 5, 1),  // �wi�to Pracy
                new DateTime(2023, 5, 3),  // �wi�to Konstytucji 3 Maja
                new DateTime(2023, 6, 4),  // Zes�anie Ducha �wi�tego
                new DateTime(2023, 6, 15), // Bo�e Cia�o
                new DateTime(2023, 8, 15), // Wniebowzi�cie Naj�wi�tszej Maryi Panny
                new DateTime(2023, 11, 1), // Wszystkich �wi�tych
                new DateTime(2023, 11, 11), // �wi�to Niepodleg�o�ci
                new DateTime(2023, 12, 25), // Bo�e Narodzenie (pierwszy dzie�)
                new DateTime(2023, 12, 26), // Bo�e Narodzenie (drugi dzie�)
            };

            //DateTime[] holidays = calendar.GetHolidays(year);


            if ((date.DayOfWeek != 0) && !holidays.Contains(date))
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
            _selectedDate = selectedDate.ToString("d");

            List<DoctorsDayPlanModel> plansDuplicated = DoctorsPlanService.CheckPlansAndReturnForADay(selectedDate, duplicateCalendar == null ? 0 : duplicateCalendar.IdCalendar);
            List<DoctorsDayPlanModel> plansOriginal = DoctorsPlanService.CheckPlansAndReturnForADay(selectedDate, CalendarService.GetCalendarIdByDate(displayMonth.ToString("d")));
            List<DoctorsDayPlanModel> plans = plansDuplicated.Concat(plansOriginal).ToList();

            dataGridViewAppointments.Rows.Clear();

            plans.ForEach(plan =>
            {
                dataGridViewAppointments.Rows.Add(plan.IdEmployee, plan.IdDay, DoctorsPlanService.GetTermDescription((EnumTerms)plan.IdOfTerm), PatientService.GetPatientById((int)(plan.PatientId == null ? 0 : plan.PatientId)));  //in database there is a null value at PatientId
            });

            //Changed as DbAppointment is not used anymore

            //List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(selectedDate, duplicateCalendar == null ? 0 : duplicateCalendar.IdCalendar);

            //dataGridViewAppointments.Rows.Clear();
            //foreach (AppointmentModel appointment in appointments)
            //{
            //    string timeTerm = AppointmentService.GetTermByTermId(appointment.IdTerm);
            //    Patient patient = PatientService.GetPatientById((int)appointment.PatientId);
            //    dataGridViewAppointments.Rows.Add(appointment.IdEmployee, appointment.IdDay, timeTerm, patient.FirstName + " " + patient.LastName);
            //}
        }


        #endregion


        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            if (_selectedDate.Length != 0)
            {

                if (CalendarService.checkIfCalendarExists(_selectedDate) == true)
                {
                    FormDoctorsDayPlanAdd formAppointmentAdd = new FormDoctorsDayPlanAdd(DateTime.Parse(labelDate.Text), currentEmployee);
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
            if (CalendarService.checkIfCalendarExistsCalendarAdd(monthAndYear))
            {
                MessageBox.Show("Calendar already exists");
                return;
            }

            CalendarModel calendarModel = new CalendarModel(monthAndYear, false);
            CalendarService.AddCalendar(calendarModel);
            MessageBox.Show("Calendar added");
            FormCalendarsList formCalendarsList = new FormCalendarsList(currentEmployee);
            Hide();
            formCalendarsList.ShowDialog();
            Close();
        }

        private void duplicateCalendar_Click(object sender, EventArgs e)
        {
            string monthAndYear = displayMonth.ToString("MM") + '-' + displayMonth.ToString("yyyy");

            if (CalendarService.checkIfCalendarExistsCalendarAdd(monthAndYear))
            {
                MessageBox.Show("Calendar already exists");
                return;
            }

            CalendarService.AddCalendar(new CalendarModel(monthAndYear, false));

            List<DoctorsDayPlanModel> plans = new List<DoctorsDayPlanModel>();
            DoctorsPlanService.CheckPlansAndReturnForAMonth(duplicateCalendar.IdCalendar).ForEach(plan =>
            {
                if (!CheckTheHoliday(new DateTime(int.Parse(displayMonth.ToString("yyyy")), int.Parse(displayMonth.ToString("MM")), plan.IdDay)))
                {
                    plan.IdCalendar = CalendarService.GetCalendarIdByDate(displayMonth.ToString("d"));
                    plan.IdDoctorsDayPlan = 0;
                    plans.Add(plan);
                }
            });

            plans.ForEach(plan => DoctorsPlanService.AddPlan(plan));
            MessageBox.Show("Calendar was duplicated!");
            FormCalendarsList formCalendarsList = new FormCalendarsList(currentEmployee);
            Hide();
            formCalendarsList.ShowDialog();
            Close();

        }

        private void editCalendar_Click(object sender, EventArgs e)
        {
            if (CalendarService.GetCalendarById(CalendarService.GetCalendarIdByDate(displayMonth.ToString("d"))).Active)
            {
                MessageBox.Show("It is not possible to change active calendars. Check if the selected calendar is right.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormCalendarEdit formCalendarEdit = new FormCalendarEdit(currentEmployee, CalendarService.GetCalendarById(CalendarService.GetCalendarIdByDate(displayMonth.ToString("d"))), new FormDoctorsPlanCalendar(currentEmployee, CalendarService.GetCalendarIdByDate(displayMonth.ToString("d"))));
            formCalendarEdit.ShowDialog();
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

        private bool CheckTheHoliday(DateTime date)
        {
            DateTime[] holidays = new DateTime[] {
                new DateTime(displayMonth.Year, 1, 1),  // Nowy Rok
                new DateTime(displayMonth.Year, 1, 6),  // �wi�to Trzech Kr�li
                new DateTime(displayMonth.Year, 4, 17), // Poniedzia�ek Wielkanocny
                new DateTime(displayMonth.Year, 5, 1),  // �wi�to Pracy
                new DateTime(displayMonth.Year, 5, 3),  // �wi�to Konstytucji 3 Maja
                new DateTime(displayMonth.Year, 6, 4),  // Zes�anie Ducha �wi�tego
                new DateTime(displayMonth.Year, 6, 15), // Bo�e Cia�o
                new DateTime(displayMonth.Year, 8, 15), // Wniebowzi�cie Naj�wi�tszej Maryi Panny
                new DateTime(displayMonth.Year, 11, 1), // Wszystkich �wi�tych
                new DateTime(displayMonth.Year, 11, 11), // �wi�to Niepodleg�o�ci
                new DateTime(displayMonth.Year, 12, 25), // Bo�e Narodzenie (pierwszy dzie�)
                new DateTime(displayMonth.Year, 12, 26), // Bo�e Narodzenie (drugi dzie�)
            };

            return holidays.ToList().Contains(date);
        }
    }
}