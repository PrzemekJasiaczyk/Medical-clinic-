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
    

    public partial class FormSpecializationAdd : Form
    {
        string errorMessage;
        EmployeeModel currentUser;
        public FormSpecializationAdd(EmployeeModel currentU)
        {
            InitializeComponent();
            currentUser = currentU;
        }

        

        private void FormSpecializationAdd_Load(object sender, EventArgs e)
        {
            loadDataGridView();   
        }

        private void loadDataGridView()
        {
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();
            dataGridViewSpecializations.DataSource = specializations;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            //this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string specializationToAdd = textBoxName.Text;

            if (SpecializationService.CheckIfSpecializationExists(specializationToAdd))
            {
                MessageBox.Show("Specialization already exists");
                return;
            }

            SpecializationService.AddSpecialization(specializationToAdd);

            MessageBox.Show("New Specialization Added");
            loadDataGridView();
        }



        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string nameSpecialization = textBoxName.Text;
            int idSpecialization = SpecializationService.getSpecializationIdByName(nameSpecialization);

            if (idSpecialization == 0)
            {
                MessageBox.Show("There in no such specialization in the database");
                return;
            }

            if (SpecializationService.checkIfSpecializationIsAssigned(EmployeeService.GetEmployeesData(), SpecializationService.getSpecializationIdByName(nameSpecialization)))
            {
                MessageBox.Show("Specialization can not be removed, it is being used by employees");
                return;
            }

            SpecializationService.RemoveSpecialization(nameSpecialization);
            loadDataGridView();
        }


        private void buttonReplace_Click_1(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length==0 || textBoxNewName.Text.Length == 0)
            {
                MessageBox.Show("Missing Input");
                return;
            }
            if (textBoxName.Text==textBoxNewName.Text)
            {
                MessageBox.Show("New Name and Old Name are the Same");
                return;
            }

            SpecializationService.EditSpecialization(textBoxName.Text, textBoxNewName.Text, out errorMessage);
            loadDataGridView();
            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            {
                buttonAdd.Enabled = true;
                buttonRemove.Enabled = true;
                buttonReplace.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonRemove.Enabled = false;
                buttonReplace.Enabled= false;
            }
        }

        private void dataGridViewSpecializations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string nameValue = dataGridViewSpecializations.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxName.Text = nameValue;
            }
        }
    }
}
