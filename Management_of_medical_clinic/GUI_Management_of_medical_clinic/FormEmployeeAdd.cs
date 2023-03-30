using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
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
    public partial class FormEmployeeAdd : Form
    {
        EmployeeModel currentUser;
        public FormEmployeeAdd(EmployeeModel currentU)
        {
            InitializeComponent();
            currentUser = currentU;
            comboBoxRole.DataSource = Enum.GetValues(typeof(EnumEmployeeRoles));
            checkIfMedicalDoctor();
        }

        private void FormEmployeeAdd_Load(object sender, EventArgs e)
        {
            comboBoxSex.SelectedIndex = 0;

            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();
            using AppDbContext context = new AppDbContext();

            foreach (SpecializationModel specialization in specializations)
            {
                checkedListBoxSpecialization.Items.Add(specialization.Name);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            //this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            (string stringPESEL, bool booleanPESEL) = EmployeeService.validatePESEL(textBoxPESEL.Text, dateTimePickerDate.Value, comboBoxSex.SelectedIndex);
            if (!booleanPESEL)
            {
                MessageBox.Show(stringPESEL);
                return;
            }

            (string stringEmail, bool booleanEmail) = EmployeeService.validateEmail(textBoxEmail.Text, textBoxFirstName.Text);
            if (!booleanEmail)
            {
                MessageBox.Show(stringEmail);
                return;
            }

            (string stringPhone, bool booleanPhone) = EmployeeService.validatePhone(textBoxPhone.Text);
            if (!booleanPhone)
            {
                MessageBox.Show(stringPhone);
                return;
            }

            if (comboBoxRole.Text == "MedicalDoctor" && checkedListBoxSpecialization.CheckedItems.Count == 0)
            {
                MessageBox.Show("A specialization needs to be selected");
                return;
            }

            FormEmployeeAddUser employeeAddUser = new FormEmployeeAddUser(currentUser);
            //this.Hide();
            employeeAddUser.ShowDialog();
            this.Close();
        }

        //Check if all required data is filled

        public void checkIfRequiredFilled()
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxPESEL.Text.Length == 11 && comboBoxRole.Text.Length > 0)
            {
                buttonNext.Enabled = true;
            }
            else
            {
                buttonNext.Enabled = false;
            }
        }
        public void checkIfMedicalDoctor()
        {
            if (comboBoxRole.Text == "MedicalDoctor")
            {
                checkedListBoxSpecialization.Visible = true;
                labelSpecialization.Visible = true;
            }

            else
            {
                checkedListBoxSpecialization.Visible = false;
                labelSpecialization.Visible = false;
            }
        }
        //Allow only one item to be checked
        private void checkedListBoxSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBoxSpecialization.SelectedIndex;
            foreach (int i in checkedListBoxSpecialization.CheckedIndices)
            {
                checkedListBoxSpecialization.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkedListBoxSpecialization.SetItemCheckState(selectedIndex, CheckState.Checked);
        }
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void textBoxPESEL_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
            checkIfMedicalDoctor();
        }
    }
}
