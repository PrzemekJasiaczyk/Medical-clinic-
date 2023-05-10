using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendarDetails : Form
    {
        EmployeeModel currentUser;
        AppointmentModel appointment;

        public FormDoctorCalendarDetails(AppointmentModel? appointment, EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            this.appointment = appointment;
            InitializeComponent();

            //List<AppointmentModel> appointments = AppointmentService.CheckAppointmentsAndReturnList(DateTime.Today.Date);

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser);
            this.Hide();
            formDoctorCalendar.ShowDialog();
            this.Close();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            FormDoctorCalendarModify formDoctorCalendarModify = new FormDoctorCalendarModify(appointment, currentUser);
            this.Hide();
            formDoctorCalendarModify.ShowDialog();
            this.Close();
        }

        private void FormDoctorCalendarDetails_Load(object sender, EventArgs e)
        {
            Patient patient = PatientService.GetPatientById((int)appointment.PatientId);

            lblAppPatient.Text = "Patient: " + patient.FirstName + " " + patient.LastName;
            lblApCost.Text = "Cost: " + appointment.Cost;
            lblAppDate.Text = "Date: " + appointment.IdDay;
            lblTerm.Text = "Term: " + AppointmentService.GetTermByTermId(appointment.IdTerm);
            lblOfficeNumber.Text = "Office number: " + appointment.IdOffice.ToString();
        }

        
    }
}
