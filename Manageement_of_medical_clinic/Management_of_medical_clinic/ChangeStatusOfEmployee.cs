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
    public partial class ChangeStatusOfEmployee : Form
    {
        EmployeeService employeeService;
        Employee employee;
        string eventChange;
        string password = "1234";
        public ChangeStatusOfEmployee(EmployeeService service, Employee emp, string eventChange)
        {
            InitializeComponent();
            employeeService = service;
            employee = emp;
            this.eventChange = eventChange;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != password)
            {
                MessageBox.Show("Invalid password!");
            }
            else if (eventChange == "deact")
            {
                employeeService.DeactivateEmployee(employee);
                Close();
            }
            else if (eventChange == "act")
            {
                employeeService.ActivateEmployee(employee);
                Close();
            }
        }

        private void ChangeStatusOfEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
