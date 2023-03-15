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
    public partial class FormChangeStatusOfEmployee : Form
    {
        
        EmployeeModel employee;
        
        public FormChangeStatusOfEmployee(EmployeeModel emp)
        {
            InitializeComponent();
            employee = emp;
        }

        private void FormChangeStatusOfEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEmployeeList formEmployeeList = new FormEmployeeList(employee);
            this.Hide();
            formEmployeeList.ShowDialog();
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != employee.Password)
            {
                MessageBox.Show("Invalid password!");
                return;
            }

            employee.ChangeEmployeeStatus(employee);
            FormEmployeeList formEmployeeList = new FormEmployeeList(employee);
            this.Hide();
            formEmployeeList.ShowDialog();
            this.Close();
        }
    }
}
