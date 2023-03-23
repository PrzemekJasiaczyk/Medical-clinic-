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
            //this.Hide();
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

        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRemove_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditPrevious_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReplace_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("<<THIS BUTTON DOESN'T WORK YET>>");
        }
    }
}
