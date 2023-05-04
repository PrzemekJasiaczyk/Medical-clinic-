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
    public partial class FormCalendarRejectConfirm : Form
    {
        CalendarModel calendar;
        public FormCalendarRejectConfirm()
        {
            InitializeComponent();
        }

        public FormCalendarRejectConfirm(CalendarModel calendar)
        {
            this.calendar=calendar;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //changing status in progress...
            MessageBox.Show("Calendar is rejected");
            Hide();
            Close();
        }
    }
}
