using Calendar;
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
    public partial class FormBlankOrPreviousCalendar : Form
    {
        EmployeeModel currentUser;
        public FormBlankOrPreviousCalendar(EmployeeModel currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void FormBlankOrPreviousCalendar_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormCalendarsList formCalendarsList = new FormCalendarsList(currentUser);
            formCalendarsList.ShowDialog();
            Close();
        }

        private void buttonBlankForm_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new(currentUser);
            formCalendar.ShowDialog();
            Close();
        }

        private void buttonPreviousForm_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new(currentUser);
            formCalendar.ShowDialog();
            Close();
        }
    }
}
