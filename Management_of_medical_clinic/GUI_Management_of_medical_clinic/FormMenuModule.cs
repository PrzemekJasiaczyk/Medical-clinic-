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
    public partial class FormMenuPatient : Form
    {
        EmployeeModel currentUser;
        public FormMenuPatient(EmployeeModel employee)
        {
            InitializeComponent();
            currentUser = employee;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenuPatient_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            Hide();
            employeeList.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonListPatient_Click(object sender, EventArgs e)
        {
            FormPatientList formPatientList = new FormPatientList(currentUser);
            Hide();
            formPatientList.ShowDialog();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            Hide();
            formMenu.ShowDialog();
            
        }
    }
}
