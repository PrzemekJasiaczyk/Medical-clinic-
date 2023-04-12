using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormUserEdit : Form
    {
        EmployeeModel currentUser;
        UserModel user;

        public FormUserEdit()
        {
            InitializeComponent();
        }

        public FormUserEdit(UserModel user, EmployeeModel currentUser)
        {
            this.user = user;
            this.currentUser = currentUser;

            InitializeComponent();
        }

        private void FormUserEdit_Load(object sender, EventArgs e)
        {
            textBoxUserId.Text = user.IdUser.ToString();
            textBoxUsername.Text = user.Username;
            comboBoxRole.SelectedItem = user.Role.ToString();
            comboBoxActive.SelectedItem = user.IsActive ? "Active" : "Disactive";

            foreach (EmployeeModel employee in EmployeeService.GetEmployeesData())
            {
                if (!UserService.CheckIfIdIsAlreadyUsed(employee.IdEmployee) || employee.IdEmployee == user.IdEmployee)
                {
                    listBoxEmployees.Items.Add(employee.IdEmployee + " " + employee.FirstName + " " + employee.LastName);
                }
            }
            if (listBoxEmployees.Items.Count == 0) listBoxEmployees.Items.Add("There are no employees without a user.");
            listBoxEmployees.SelectedIndex = 0;
            checkIfRequiredFilled();
        }

        public void checkIfRequiredFilled()
        {
            buttonSaveUser.Enabled = false;
            if (textBoxUsername.Text.Trim().Length > 0 && listBoxEmployees.SelectedItem != null && comboBoxRole.SelectedItem != null && comboBoxActive.SelectedItem != null)
            {
                //taki problem, że wychodzi false || false || fasle = true
                //MessageBox.Show("user.IdEmployee != int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @\" ^\\d + \").Value): " + (user.IdEmployee != int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value)));
                //MessageBox.Show("!comboBoxRole.SelectedItem.ToString().Equals(user.Role.ToString()): " + (!comboBoxRole.SelectedItem.ToString().Equals(user.Role.ToString())));
                //MessageBox.Show("comboBoxActive.SelectedItem != (user.IsActive ? \"Active\" : \"Disactive\"): " + (comboBoxActive.SelectedItem != (user.IsActive ? "Active" : "Disactive")));
                //MessageBox.Show("listBoxEmployees.Items[0].ToString() != \"There are no employees without a user.\": " + (listBoxEmployees.Items[0].ToString() != "There are no employees without a user."));

                //bool what = user.IdEmployee != int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value) || comboBoxRole.SelectedItem.ToString().Equals(user.Role.ToString()) || comboBoxActive.SelectedItem.Equals(user.IsActive ? "Active" : "Disactive");
                //MessageBox.Show(what.ToString());

                if ((listBoxEmployees.Items[0].ToString() != "There are no employees without a user.") && (user.IdEmployee != int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value) || comboBoxRole.SelectedItem.ToString().Equals(user.Role.ToString()) || comboBoxActive.SelectedItem.Equals(user.IsActive ? "Active" : "Disactive")))
                {
                    buttonSaveUser.Enabled = true;
                }
            }
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            UserService.EditUser(int.Parse(textBoxUserId.Text), textBoxUsername.Text, (EnumUserRoles)Enum.Parse(typeof(EnumUserRoles), comboBoxRole.SelectedItem.ToString()), comboBoxActive.SelectedItem == "Active" ? true : false, int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value));

            MessageBox.Show("Success, data is saved.");
            Hide();
        }
        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if(user.IdEmployee != int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value) || comboBoxRole.SelectedItem.ToString().Equals(user.Role.ToString()) || comboBoxActive.SelectedItem.Equals(user.IsActive ? "Active" : "Disactive"))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the operation? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    return;
                }
            }
            Hide();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void comboBoxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.Items[0].ToString().Equals("There are no employees without a user."))
            {
                listBoxEmployees.SelectedItem = null;
            }
            checkIfRequiredFilled();
        }
    }
}
