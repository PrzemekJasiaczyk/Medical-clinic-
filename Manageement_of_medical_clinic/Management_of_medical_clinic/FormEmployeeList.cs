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
    public partial class FormEmployeeList : Form
    {
        EmployeeService service = new EmployeeService();
        Employee employee;
        string[] roles = { "Employee", "Doctor", "none" };

        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Clear();
            dataGridViewEmployees.DataSource = service.GetEmployeeTable();
            comboBoxRole.Items.AddRange(roles);
            addEditBtnColumn();

            foreach (DataGridViewColumn dgvc in dataGridViewEmployees.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void addEditBtnColumn()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.UseColumnTextForButtonValue = true;
            editButton.Name = "edit_column";
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            int columnIndex = dataGridViewEmployees.Columns.Count;
            if (dataGridViewEmployees.Columns["edit_column"] == null)
                dataGridViewEmployees.Columns.Insert(columnIndex, editButton);
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
                FormChangeStatusOfEmployee deactivate = new FormChangeStatusOfEmployee(service, employee, "deact");
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
                employee = service.Employees[e.RowIndex];
            }

        }

        private void buttonReactivate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one employee from list!");
            }
            else if (employee.IsActive)
            {
                MessageBox.Show("Employee is active!");
            }
            else
            {
                FormChangeStatusOfEmployee reactivate = new FormChangeStatusOfEmployee(service, employee, "act");
                reactivate.ShowDialog();
                EmployeeList_Load(sender, e);
                Show();
            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int employeeIndex = dataGridViewEmployees.CurrentCell.RowIndex;

                if (service.EmployeeListCount() <= employeeIndex)
                    return;

                FormEmployeeEdit employeeEdit = new FormEmployeeEdit(service.Employees[employeeIndex]);
                this.Hide();
                employeeEdit.ShowDialog();
                this.Close();
            }
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
                FormEmployeeDetailsView employeeDetailsView = new FormEmployeeDetailsView(employee);
                this.Hide();
                employeeDetailsView.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select one employee from list!");
            }

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

            FormEmplyeeAdd employeeAdd = new FormEmplyeeAdd();
            this.Hide();
            employeeAdd.ShowDialog();
            this.Close();
        }
    }
}
