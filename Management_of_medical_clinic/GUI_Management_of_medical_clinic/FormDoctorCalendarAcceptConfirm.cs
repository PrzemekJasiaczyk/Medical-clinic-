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
    public partial class FormDoctorCalendarAcceptConfirm : Form
    {
        string selectedDate;
        EmployeeModel currentUser;

        public FormDoctorCalendarAcceptConfirm(string selectedDate, EmployeeModel currentUser)
        {
            InitializeComponent();
            this.selectedDate=selectedDate;
            this.currentUser = currentUser;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Canceled calendar's accepting");
            Hide();
            Close();
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser);
            formDoctorCalendar.Show();          
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(selectedDate);
            int cal_id = CalendarService.GetCalendarIdByDate(date.ToString("d"));
            List<DoctorsDayPlanModel> list = DoctorsPlanService.GetPlansByCalendarId(cal_id);
           foreach (DoctorsDayPlanModel appointments in list)
            {
                DoctorsPlanService.ChangeAppointmentStatusToAccepted(appointments.IdDoctorsDayPlan, currentUser);
            }
            CalendarService.ChangeCalendarStatusToAccepted(cal_id);
            MessageBox.Show("Calendar is accepted");
            Hide();
            Close();
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser);
            formDoctorCalendar.Show();
        }

    }
}
