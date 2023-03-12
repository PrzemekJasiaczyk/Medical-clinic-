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
    public partial class FormEmployeeEdit : Form
    {
        EmployeeModel employee;
        public FormEmployeeEdit(EmployeeModel emp)
        {
            InitializeComponent();
            this.employee = emp;
        }

        private void FormEmployeeEdit_Load(object sender, EventArgs e)
        {
            comboBoxRole.SelectedItem = employee.Role;
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxPESEL.Text = employee.PESEL;
            textBoxDateOfBirth.Text = employee.DateOfBirth.ToString();
            correspAddressTextBox.Text = employee.CorrespondenceAddress;
            textBoxEmail.Text = employee.Email;
            phoneNumberTextBox.Text = employee.PhoneNumber;
            textBoxSex.Text = employee.Sex.ToString();
        }
        private void checkForms()
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxPESEL.Text.Length > 0 && comboBoxRole.Text.Length > 0)
                buttonConfirm.Enabled = true;
            else
                buttonConfirm.Enabled = false;
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void textBoxPESEL_TextChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkForms();
        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList();
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }
    }
}
