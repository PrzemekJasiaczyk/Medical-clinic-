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
    public partial class FormAppointmentAdd : Form
    {
        DateTime date;
        EmployeeModel currentEmployee;
        public FormAppointmentAdd(DateTime date, EmployeeModel currentEmployee)
        {
            this.date = date;
            this.currentEmployee = currentEmployee;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new FormCalendar(currentEmployee);
            this.Hide();
            formCalendar.Show();
            this.Hide();
        }

        private void FormAppointmentAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
