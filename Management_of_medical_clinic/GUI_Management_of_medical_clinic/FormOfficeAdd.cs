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
    public partial class FormOfficeAdd : Form
    {
        EmployeeModel currentUser;

        public FormOfficeAdd()
        {
            InitializeComponent();
        }

        public FormOfficeAdd(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!textBoxNumber.Text.Trim().Equals("") || !textBoxInfo.Text.Trim().Equals("") || listBoxSpecializations.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the operation? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormOfficeList officeList = new FormOfficeList(currentUser);
                    officeList.ShowDialog();
                    Close();
                }
            }
            else
            {
                FormOfficeList officeList = new FormOfficeList(currentUser);
                officeList.ShowDialog();
                Close();
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            if (OfficeService.CheckIfNumberExists((int.Parse(textBoxNumber.Text)))) { MessageBox.Show("The number of room entered is already taken. Please choose a different number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            OfficeService.AddOffice(new OfficeModel(int.Parse(textBoxNumber.Text), int.Parse(Regex.Match(listBoxSpecializations.SelectedItem.ToString(), @"^\d+").Value), true, textBoxInfo.Text));

            FormOfficeList officeList = new FormOfficeList(currentUser);
            officeList.ShowDialog();
            Close();
        }

        public void checkIfRequiredFilled()
        {
            int result = 0;
            if (textBoxNumber.Text.Length > 0 && textBoxInfo.Text.Length > 0 && listBoxSpecializations.SelectedItem != null && int.TryParse(textBoxNumber.Text, out result))
            {
                buttonAddNewOffice.Enabled = true;
            }
            else
            {
                buttonAddNewOffice.Enabled = false;
            }
        }

        private void FormOfficeAdd_Load(object sender, EventArgs e)
        {
            foreach (SpecializationModel specialization in SpecializationService.GetSpecializationsData())
            {
                listBoxSpecializations.Items.Add(specialization.IdSpecialization + " " + specialization.Name);
            }
            checkIfRequiredFilled();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void listBoxSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }
    }
}
