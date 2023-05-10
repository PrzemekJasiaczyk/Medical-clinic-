using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
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

        public FormDoctorDashboard()
        {
            InitializeComponent();
        }

        public FormDoctorDashboard(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            label1.Text = "Welcome, " + currentUser.FirstName + " " + currentUser.Role;

            List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(DateTime.Today.Date);

            dataGridViewAppointments.Rows.Clear();
            dataGridViewAppointments.Columns.Add("Room", "Room");
            dataGridViewAppointments.Columns.Add("Hour", "Hour");
            dataGridViewAppointments.Columns.Add("Patient", "Patient");
            foreach (AppointmentModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee)
                {
                    string timeTerm = AppointmentService.GetTermByTermId(appointment.IdTerm);
                    Patient patient = PatientService.GetPatientById((int)appointment.PatientId);
                    dataGridViewAppointments.Rows.Add(/*currentEmployee.IdEmployee, appointment.IdDay,*/ appointment.IdOffice, timeTerm, patient.FirstName + " " + patient.LastName);
                }
            }
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            bool isNewCalendar = false;
            List<CalendarModel> calendars = new List<CalendarModel>();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.IdEmployee == currentUser.IdEmployee && calendar.Active == false)
                {
                    isNewCalendar = true;
                }
            }
            if (isNewCalendar = true)
            {
                this.Hide();
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
            menu.ShowDialog();
            Close();
        }

        private void buttonCurrentCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormDoctorCurrentCalendar formDoctor = new FormDoctorCurrentCalendar(currentUser);
            this.currentUser = currentUser;

            formDoctor.ShowDialog();
            this.Close();
        }
    }
}
