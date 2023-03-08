using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.VisualBasic;
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
            int row = dataGridViewEmployees.CurrentRow.Index;

            if (row >= 0 && row < service.EmployeeListCount() && dataGridViewEmployees.SelectedCells.Count < dataGridViewEmployees.ColumnCount + 1)
            {
                string? firstName = dataGridViewEmployees.Rows[row].Cells[0].Value.ToString();
                string? lastName = dataGridViewEmployees.Rows[row].Cells[1].Value.ToString();
                string? role = dataGridViewEmployees.Rows[row].Cells[2].Value.ToString();

                employee = service.ReturnCorrectEmployee(firstName, lastName, role);
                //MessageBox.Show(employee.FirstName.ToString());
                EmployeeDetailsView employeeDetailsView = new EmployeeDetailsView(employee);
                Hide();
                employeeDetailsView.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Select one employee from list!");
            }

        }
    }
}
