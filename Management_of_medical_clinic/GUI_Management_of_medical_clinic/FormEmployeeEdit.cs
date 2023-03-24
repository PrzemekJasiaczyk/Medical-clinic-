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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormEmployeeEdit : Form
    {
        EmployeeModel employee;
        EmployeeModel currentUser;
        public FormEmployeeEdit(EmployeeModel emp, EmployeeModel currentU)
        {
            InitializeComponent();
            this.employee = emp;
            currentUser = currentU;
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
            
        }
        private void checkForms()
        {
            if (textBoxFirstName.Text.Length > 0 && textBoxLastName.Text.Length > 0 && textBoxPESEL.Text.Length > 0 && comboBoxRole.Text.Length > 0 && comboBoxSex.SelectedItem!=null)
                buttonConfirm.Enabled = true;
            else
                buttonConfirm.Enabled = false;
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            /*(string stringPESEL, bool booleanPESEL) = EmployeeService.validatePESEL(textBoxPESEL.Text, textBoxDateOfBirth.Value, comboBoxSex.SelectedIndex);
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

            (string stringPhone, bool booleanPhone) = EmployeeService.validatePhone(phoneNumberTextBox.Text);
            if (!booleanPhone)
            {
                MessageBox.Show(stringPhone);
                return;
            }*/

            
            EnumSex enumSex = (EnumSex)Enum.Parse(typeof(EnumSex), comboBoxSex.SelectedItem.ToString());
            EmployeeModel.EditEmployee(employee.IdEmployee, textBoxFirstName.Text, textBoxLastName.Text, textBoxPESEL.Text, textBoxDateOfBirth.Text, comboBoxRole.Text, correspAddressTextBox.Text, textBoxEmail.Text, phoneNumberTextBox.Text, enumSex);

            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            this.Hide();
            employeeList.ShowDialog();
            this.Close();

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
            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void correspAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkForms();
        }
    }
}
