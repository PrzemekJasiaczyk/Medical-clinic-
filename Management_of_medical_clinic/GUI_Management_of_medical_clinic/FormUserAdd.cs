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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormUserAdd : Form
    {
        EmployeeModel currentUser;
        public FormUserAdd(EmployeeModel user)
        {
            currentUser = user;
            InitializeComponent();
        }


        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            foreach (EmployeeModel employee in EmployeeService.GetEmployeesData())
            {
                if (!UserService.CheckIfIdIsAlreadyUsed(employee.IdEmployee))
                {
                    listBoxEmployees.Items.Add(employee.IdEmployee + " " + employee.FirstName + " " + employee.LastName);
                }
            }
            if (listBoxEmployees.Items.Count == 0) listBoxEmployees.Items.Add("There are no employees without a user.");
            checkIfRequiredFilled();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!textBoxUsername.Text.Trim().Equals("") || !textBoxPassword.Text.Trim().Equals("") || !textBoxPasswordConfirm.Text.Trim().Equals("") || listBoxEmployees.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the operation? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormUserList userList = new FormUserList(currentUser);
                    this.Hide();
                    userList.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                FormUserList userList = new FormUserList(currentUser);
                this.Hide();
                userList.ShowDialog();
                this.Close();
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            if (UserService.CheckIfUsernameExists(textBoxUsername.Text)) { MessageBox.Show("Username is already taken"); return; }
            else if (!textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text)) { MessageBox.Show("Passwords don't match"); return; }

            UserService.AddUser(textBoxUsername.Text, textBoxPassword.Text, (EnumUserRoles)Enum.Parse(typeof(EnumUserRoles), comboBoxRole.SelectedItem.ToString()), true, int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value));

            //FormUserList userList = new FormUserList(currentUser);
            //this.Hide();
            //userList.ShowDialog();
            //this.Close();

            Hide();
        }

        public void checkIfRequiredFilled()
        {
            if (textBoxUsername.Text.Trim().Length > 0 && textBoxPassword.Text.Trim().Length > 0 && textBoxPasswordConfirm.Text.Trim().Length > 0 && listBoxEmployees.Items[0].ToString() != "There are no employees without a user." && listBoxEmployees.SelectedItem != null && comboBoxRole.SelectedItem != null)
            {
                buttonAddNewUser.Enabled = true;
            }
            else
            {
                buttonAddNewUser.Enabled = false;
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

        private void listBoxEmployeesWithout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.Items[0].ToString().Equals("There are no employees without a user."))
            {
                listBoxEmployees.SelectedItem = null;
            }
            checkIfRequiredFilled();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }
    }
}
