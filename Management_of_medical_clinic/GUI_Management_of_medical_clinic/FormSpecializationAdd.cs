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
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string specializationToAdd = textBoxAdd.Text;

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
            string specializationToRemove = textBoxRemove.Text;

            if (SpecializationService.RemoveSpecialization(specializationToRemove))
            {
                MessageBox.Show("Specialization removed successfully");
                loadDataGridView();
                return;
            }
            MessageBox.Show("Specialization doesn't exist");
            return;
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdd.Text.Length > 0)
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }

        private void textBoxRemove_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRemove.Text.Length > 0)
            {
                buttonRemove.Enabled= true;
            }
            else
            {
                buttonRemove.Enabled = false;
            }
        }

        private void textBoxEditPrevious_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEditPrevious.Text.Length > 0 && textBoxEditNew.Text.Length > 0)
            {
                buttonReplace.Enabled= true;
            }
            else
            {
                buttonReplace.Enabled = false;
            }
        }

        private void textBoxEditNew_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEditPrevious.Text.Length > 0 && textBoxEditNew.Text.Length > 0)
            {
                buttonReplace.Enabled = true;
            }
            else
            {
                buttonReplace.Enabled = false;
            }
        }
    }
}
