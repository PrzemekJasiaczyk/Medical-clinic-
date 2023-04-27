using Calendar;
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
    public partial class FormAppointmentAdd : Form
    {
        DateTime selectedDate;
        int selectedDay;
        EmployeeModel currentEmployee;

        public FormAppointmentAdd(DateTime date, EmployeeModel currentEmployee)
        {
            selectedDate = date;
            selectedDay = date.Day;
            this.currentEmployee = currentEmployee;
            InitializeComponent();

            try
            {
                comboBoxCalendar.DataSource = CalendarService.GetCalendarIds();
                comboBoxPatient.DataSource = PatientService.GetPatientIds();
                comboBoxDoctor.DataSource = EmployeeService.GetDoctorIds();
                comboBoxOffice.DataSource = OfficeService.GetCalendarIds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            try
            {
                comboBoxCalendar.SelectedIndex = 0;
                comboBoxPatient.SelectedIndex = 0;
                comboBoxDoctor.SelectedIndex = 0;
                comboBoxOffice.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Some data might be missing");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void FormAppointmentAdd_Load(object sender, EventArgs e)
        {
            labelDay.Text = "Selected Date: " + selectedDate.ToString("d");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTerm.SelectedIndex < 0) return;

                string term = comboBoxTerm.SelectedItem.ToString();
                int idTerm = AppointmentService.GetIdTerm(term);

                AppointmentModel appointmentModel = new AppointmentModel(idTerm, 1000, selectedDay, true, 1, 1, 1, 1);
                AppointmentService.AddAppointment(appointmentModel);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new FormCalendar(currentEmployee);
            this.Hide();
            formCalendar.Show();
            this.Hide();
        }
    }
}
