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
        DoctorsDayPlanModel appointment;

        public FormDoctorCalendarDetails(DoctorsDayPlanModel? DoctorsDayPlanModel, EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            this.appointment = appointment;
            InitializeComponent();
            LoadAppointmentData();

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser,appointment);
            this.Hide();
            formDoctorCalendar.ShowDialog();
            this.Close();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //FormDoctorCalendarModify formDoctorCalendarModify = new FormDoctorCalendarModify(appointment, currentUser);
            this.Hide();
            //formDoctorCalendarModify.ShowDialog();
            this.Close();
        }

        private void FormDoctorCalendarDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadAppointmentData()
        {
            //Patient patient = PatientService.GetPatientById((int)appointment.PatientId);

            //lblAppPatient.Text = "Patient: " + patient.FirstName + " " + patient.LastName;
            lblApCost.Text = "Cost: " + appointment.Cost;
            DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);
            lblAppDate.Text = "Date: " + date.ToString("dd.MM.yyyy");
            //lblTerm.Text = "Term: " + DoctorsDayPlanModel.GetTermByTermId(appointment.IdTerm);
            lblOfficeNumber.Text = "Office number: " + appointment.IdOffice.ToString();
        }
        
    }
}
