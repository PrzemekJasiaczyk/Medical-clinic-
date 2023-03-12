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
        public FormSpecializationAdd()
        {
            InitializeComponent();
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
            FormEmployeeList employeeList = new FormEmployeeList();
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string specializationName = textBoxName.Text;
            SpecializationService.AddSpecialization(specializationName);

            MessageBox.Show("New Specialization Added");
            loadDataGridView();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }
    }
}
