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
    public partial class EmployeeList : Form
    {
        EmployeeService service = new EmployeeService();
        string[] roles = { "Employee", "Doctor", "none" };

        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            dataGridViewEmployees.DataSource = service.GetEmployeeTable();
            comboBoxRole.Items.AddRange(roles);
        }

        private void buttonFilterEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewEmployees.DataSource = service.FilterEmployee(Convert.ToString(comboBoxRole.SelectedItem), checkBoxIsActive.Checked);
            }
            catch
            {
                MessageBox.Show("Wybierz warianty filtrowania!");
            }
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.DataSource = service.GetEmployeeTable();
        }
    }
}
