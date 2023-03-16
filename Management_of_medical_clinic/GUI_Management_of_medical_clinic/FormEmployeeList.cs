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
    public partial class FormEmployeeList : Form
    {
        EmployeeService service = new EmployeeService();    //for remove
        EmployeeModel currentUser;     // from now 'employee object' which is moving beetween forms is person logged to system
        string[] roles = { "Employee", "Doctor", "none" };

        void LoadEmployeeData()
        {
            dataGridViewEmployees.DataSource = null;

            if (dataGridViewEmployees.Rows.Count > 0)
            {
                dataGridViewEmployees.Rows.Clear();
            }

            foreach (EmployeeModel employee in EmployeeService.GetEmployeesData())
            {
                dataGridViewEmployees.Rows.Add(employee.IdEmployee, employee.FirstName, employee.LastName, employee.Role, (employee.IsActive == true) ? "Active" : "Not Active");

                if (currentUser.IdEmployee == currentUser.IdEmployee) { currentUser = employee; }     // it makes user always refreshed
            }
            
        }

        public FormEmployeeList(EmployeeModel emp)
        {
            currentUser = emp;
            InitializeComponent();
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            dataGridViewEmployees.Rows.Clear();
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.AddRange(roles);
            dataGridViewEmployees.Columns.Add("IdEmployee", "Id of Employee");
            dataGridViewEmployees.Columns.Add("FirstName", "First Name");
            dataGridViewEmployees.Columns.Add("LastName", "Last Name");
            dataGridViewEmployees.Columns.Add("Role", "Role");
            dataGridViewEmployees.Columns.Add("IsActive", "Is active?");
            

            LoadEmployeeData();




            //dataGridViewEmployees.DataSource = service.GetEmployeeTable();
            /* addEditBtnColumn();
            
            foreach (DataGridViewColumn dgvc in dataGridViewEmployees.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            */
        }

        

        /*private void addEditBtnColumn()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.UseColumnTextForButtonValue = true;
            editButton.Name = "edit_column";
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            int columnIndex = dataGridViewEmployees.Columns.Count;
            if (dataGridViewEmployees.Columns["edit_column"] == null)
                dataGridViewEmployees.Columns.Insert(columnIndex, editButton);
        }*/
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
            
            LoadEmployeeData();
            comboBoxRole.SelectedItem = null;
            checkBoxIsActive.Checked = false;
        }
        private void buttonDeactivateEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one employee from list!");
                return;

            }
            int rowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
            if (dataGridViewEmployees.Rows[rowIndex].Cells["IsActive"].Value.ToString() == "Not Active")
            {
                MessageBox.Show("Employee is deactive!");
                return;
            }
            
            FormChangeStatusOfEmployee deactivate = new FormChangeStatusOfEmployee(currentUser);
            this.Hide();
            deactivate.ShowDialog();
            

        }
        private void dataGridViewEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void buttonReactivate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one employee from list!");
                return;

            }
            int rowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
            if (dataGridViewEmployees.Rows[rowIndex].Cells["IsActive"].Value.ToString() == "Active")
            {
                MessageBox.Show("Employee is active!");
                return;
            }

            FormChangeStatusOfEmployee deactivate = new FormChangeStatusOfEmployee(currentUser);
            this.Hide();
            deactivate.ShowDialog();
            
            
      
        }
        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int employeeIndex = dataGridViewEmployees.CurrentCell.RowIndex;

                if (service.EmployeeListCount() <= employeeIndex)
                    return;

                FormEmployeeEdit employeeEdit = new FormEmployeeEdit(service.Employees[employeeIndex]);
                this.Hide();
                employeeEdit.ShowDialog();
                this.Close(); 
            }*/
        }
        private void buttonReviewEmployee_Click(object sender, EventArgs e)
        {
            /* int row = dataGridViewEmployees.CurrentRow.Index;

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
            } */

        }
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

            FormEmployeeAdd employeeAdd = new FormEmployeeAdd();
            this.Hide();
            employeeAdd.ShowDialog();
            this.Close();
        }

        private void buttonSpecializations_Click(object sender, EventArgs e)
        {
            FormSpecializationAdd specializationAdd = new FormSpecializationAdd();
            this.Hide();
            specializationAdd.ShowDialog();
            this.Close();
        }
    }
}
