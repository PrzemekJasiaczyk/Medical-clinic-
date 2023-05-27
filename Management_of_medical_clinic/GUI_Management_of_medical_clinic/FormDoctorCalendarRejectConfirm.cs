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
    public partial class FormDoctorCalendarRejectConfirm : Form
    {
        EmployeeModel currentUser;
        CalendarModel calendar;
        public FormDoctorCalendarRejectConfirm(CalendarModel calendar, EmployeeModel currentUser)
        {
            InitializeComponent();
            this.calendar = calendar;
            this.currentUser = currentUser;
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled calendar's rejecting");
            Hide();
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DoctorsPlanService.ChangeAppointmentStatusToFree(calendar.IdCalendar,currentUser); //need changes hier
            MessageBox.Show("Calendar is rejected");
            Hide();
            Close();
        }
    }
}
