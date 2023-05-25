using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        DateTime selectedDate;
        string dateReference;
        int selectedDay;
        int calendarId;
        public FormDoctorCalendarDetails(DoctorsDayPlanModel? DoctorsDayPlanModel, EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            this.appointment = DoctorsDayPlanModel;
            /*
            selectedDate = date;
            selectedDay = date.Day;
            dateReference = selectedDate.ToString("d");
            calendarId = CalendarService.GetCalendarIdByDate(dateReference);*/

            InitializeComponent();
            LoadAppointmentData();

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
            FormDoctorCalendarModify formDoctorCalendarModify = new FormDoctorCalendarModify(appointment, currentUser, false, selectedDate);
            this.Hide();
            formDoctorCalendarModify.ShowDialog();
            this.Close();
        }

        private void FormDoctorCalendarDetails_Load(object sender, EventArgs e)
        {

        }

        private void LoadAppointmentData()
        {
            this.selectedDate = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);
            lblAppDate.Text = "Date: " + selectedDate.ToString("dd.MM.yyyy");
            lblTerm.Text = "Term: " + AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString();
            lblOfficeNumber.Text = "Office number: " + appointment.IdOffice.ToString();
        }


    }
}
