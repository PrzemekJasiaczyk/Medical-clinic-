namespace Calendar
{
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
        }

        DateTime displayMonth = DateTime.Today;


        private void FormCalendar_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
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
            FormCalendar.ActiveForm.Close();
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



        #endregion


    }
}