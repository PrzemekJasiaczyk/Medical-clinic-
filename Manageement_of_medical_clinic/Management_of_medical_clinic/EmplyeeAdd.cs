using Console_Management_of_medical_clinic.Logic;
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
    public partial class EmplyeeAdd : Form
    {
        public EmplyeeAdd()
        {
            InitializeComponent();
            
        }

        private void EmplyeeAdd_Load(object sender, EventArgs e)
        {
            comboBoxSex.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            this.Hide();
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

            if (comboBoxRole.Text == "Medical Doctor" && checkedListBoxSpecialization.CheckedItems.Count == 0)
            {
                MessageBox.Show("A specialization needs to be selected");
                return;
            }

            MessageBox.Show("Success");
            
        }


        //Check if all required data is filled

        public void checkIfRequiredFilled()
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxPESEL.Text.Length > 0 && comboBoxRole.Text.Length > 0)
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
            if (comboBoxRole.Text == "Medical Doctor")
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
            foreach(int i in checkedListBoxSpecialization.CheckedIndices)
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
