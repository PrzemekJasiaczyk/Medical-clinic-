using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorDashboard : Form
    {
        EmployeeModel currentUser;
        Patient? currentPatient;

        public FormDoctorDashboard()
        {
            InitializeComponent();
        }

        public FormDoctorDashboard(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            label1.Text = "Welcome, " + currentUser.FirstName;
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            bool isNewCalendar = true;
            //bool isNewCalendar = false; roboczo dałem true
            List<CalendarModel> calendars = CalendarService.GetCalendarData();

            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentUser.IdEmployee && calendar.Active == false)
                {
                    isNewCalendar = true;
                }
            }
            if (isNewCalendar == true)
            {
                FormDoctorCalendar formDoctor = new FormDoctorCalendar(currentUser);
                formDoctor.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You don't have any new calendar to check", "Information", MessageBoxButtons.OK);
            }

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void buttonCurrentCalendar_Click(object sender, EventArgs e)
        {
            IsCalendarActiveForCurrentMonth();
        }


        private void IsCalendarActiveForCurrentMonth()
        {
            bool isCurrentCalendar = false;
            string currentMonthYear = DateTime.Today.ToString("MM-yyyy");


            List<CalendarModel> calendars = CalendarService.GetCalendarData();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentUser.IdEmployee &&
                    calendar.Active == true &&
                    calendar.DateReference == currentMonthYear)
                {
                    isCurrentCalendar = true;
                    break;
                }
            }

            if (isCurrentCalendar)
            {
                ToFormCurrentCalendar();
            }
            else
            {
                MessageBox.Show("Brak takich");
            }

        }
        private void ToFormCurrentCalendar()
        {
            FormDoctorCurrentCalendar formCurrentCalendar = new FormDoctorCurrentCalendar(currentUser);
            this.Hide();
            formCurrentCalendar.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AppDbContext db = new AppDbContext();

            if (e.RowIndex >= 0)
            {
                string? row = dataGridView1.Rows[e.RowIndex].Cells["PatientId"].Value.ToString();
                currentPatient = db.Patients.FirstOrDefault(p => p.PatientId == Convert.ToUInt32(row));

                labelName.Text = $"Full Name : {currentPatient.FirstName} {currentPatient.LastName}";
                Labelpesel.Text = $"PESEL : {currentPatient.PESEL}";
                Labelsex.Text = $"Sex : {currentPatient.Sex}";
                LabelbirthDay.Text = $"Birth Day : {Convert.ToDateTime(currentPatient.BirthDate)}";
            }
        }

        private void FormDoctorDashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Room", "Room");
            dataGridView1.Columns.Add("Hour", "Hour");
            dataGridView1.Columns.Add("Patient", "Patient");
            dataGridView1.Columns.Add("Day", "Day");
            dataGridView1.Columns.Add("PatientId", "PatientId");



            AppDbContext db = new AppDbContext();

            List<DoctorsDayPlanModel> appointments = db.DbDoctorsDayPlan.ToList();
            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee &&  /*appointment.IdDay==DateTime.Now.Day &&*/  appointment.IdCalendar == 1)
                {
                    string timeTerm = AppointmentService.GetTermByTermId(appointment.IdOfTerm);

                    if (db.Patients.FirstOrDefault(p => p.PatientId == appointment.PatientId) != null)
                    {


                        Patient? patient = db.Patients.FirstOrDefault(p => p.PatientId == appointment.PatientId);
                        int index = dataGridView1.Rows.Add(appointment.IdOffice, timeTerm, patient.LastName, appointment.IdDay, patient.PatientId);
                    }
                }
            }

            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
