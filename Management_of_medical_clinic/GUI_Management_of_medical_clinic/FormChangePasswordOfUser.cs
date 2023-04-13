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
    public partial class FormChangePasswordOfUser : Form
    {
        EmployeeModel currentUser;
        UserModel user;

        public FormChangePasswordOfUser()
        {
            InitializeComponent();
        }

        public FormChangePasswordOfUser(UserModel user, EmployeeModel employee)
        {
            this.user = user;
            currentUser = employee;

            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            if (UserService.ValidatePassword(textBoxPassword.Text))
            {
                UserService.ChangePassword(user.IdUser, textBoxPassword.Text);
                MessageBox.Show("Success, password has been changed.");
                Hide();
            }
            else
            {
                MessageBox.Show("The password you entered is not valid. Please choose a stronger password that is at least 8 characters long and includes at least one lowercase letter, one uppercase letter, one digit, and one of the following special characters: - _ ! # $ *.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkIfRequiredFilled()
        {
            buttonSaveUser.Enabled = false;
            if (textBoxPassword.Text == textBoxPasswordConfirm.Text && textBoxPassword.Text.Trim().Length > 0 && textBoxPasswordConfirm.Text.Trim().Length > 0)
            {
                buttonSaveUser.Enabled = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void textBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void FormChangePasswordOfUser_Load(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }
    }
}
