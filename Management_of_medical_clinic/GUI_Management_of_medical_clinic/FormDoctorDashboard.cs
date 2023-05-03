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
            label1.Text = "Welcome, " + currentUser.FirstName + " "+currentUser.Role;
        }     

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormDoctorCalendar formDoctor = new FormDoctorCalendar(currentUser);
            this.currentUser = currentUser;

            formDoctor.ShowDialog();
            this.Close();
        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.ShowDialog();
            Close();
        }
    }
}
