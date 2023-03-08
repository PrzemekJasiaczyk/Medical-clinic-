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
        Employee employee;
        string[] roles = { "Employee", "Doctor", "none" };

        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Clear();
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
                MessageBox.Show("Select variant of filter!");
            }
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.DataSource = service.GetEmployeeTable();
            comboBoxRole.SelectedItem = null;
            checkBoxIsActive.Checked = false;
        }

        private void buttonDeactivateEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 1) 
            {
                MessageBox.Show("Select one employee from list!");
                
            }
            else if (!employee.IsActive)
            {
                MessageBox.Show("Employee is deactive!");
            }
            else
            {
                ChangeStatusOfEmployee deactivate = new ChangeStatusOfEmployee(service, employee, "deact");
                Hide();
                deactivate.ShowDialog();
                EmployeeList_Load(sender, e);
                Show();
            }
            
        }

        private void dataGridViewEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int index = service.EmployeeListCount();
            if (dataGridViewEmployees.CurrentCell.RowIndex < index)
            {
                employee = service.GetEmployeeList()[e.RowIndex];
            }

        }

        private void buttonReactivate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one employee from list!");
            }else if (employee.IsActive)
            {
                MessageBox.Show("Employee is active!");
            }
            else
            {
                ChangeStatusOfEmployee reactivate = new ChangeStatusOfEmployee(service, employee, "act");
                Hide();
                reactivate.ShowDialog();
                EmployeeList_Load(sender, e);
                Show();
            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonReviewEmployee_Click(object sender, EventArgs e)
        {
            int index = dataGridViewEmployees.CurrentRow.Index;
            employee = service.GetEmployeeList()[index];
            EmployeeDetailsView employeeDetailsView = new EmployeeDetailsView();

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            EmplyeeAdd employeeAdd = new EmplyeeAdd();
            Hide();
            employeeAdd.ShowDialog();
            Show();
        }
    }
}
