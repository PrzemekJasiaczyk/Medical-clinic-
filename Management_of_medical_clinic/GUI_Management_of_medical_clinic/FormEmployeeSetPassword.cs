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
    public partial class FormEmployeeSetPassword : Form
    {
        EmployeeModel currentUser;
        public FormEmployeeSetPassword(EmployeeModel currentU)
        {
            InitializeComponent();
            currentUser = currentU;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            if (EmployeeService.CheckIfUsernameExists(username))
            {
                MessageBox.Show("Username is already taken");
                return;
            }
            if (textBoxPassword.Text != textBoxPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords don't match");
                return;
            }

            MessageBox.Show("<<Success, but button doesn't work yet>>");

            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        public void checkIfRequiredFilled()
        {
            if (textBoxUsername.Text.Length > 0 && textBoxPassword.Text.Length > 0 && textBoxPasswordConfirm.Text.Length > 0)
            {
                buttonNext.Enabled = true;
            }
            else
            {
                buttonNext.Enabled = false;
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void textBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }
    }
}
