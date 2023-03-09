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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!validatePESEL(textBoxPESEL, dateTimePickerDate))
            {
                MessageBox.Show("PESEL is incorrect");
            }
            else
            {
                MessageBox.Show("Success!");
            }
        }




        private void EmplyeeAdd_Load(object sender, EventArgs e)
        {

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
        }


        //Validate input
        public static bool validatePESEL(TextBox textBox, DateTimePicker dateTimePicker)
        {
            string input = textBox.Text;

            DateTime selectedDate = dateTimePicker.Value;
            string formatedDate = selectedDate.ToString("MM/dd/yyyy");

            if (input.Length != 11)
            {
                return false;
            }

            if (!long.TryParse(input, out long result))
            {
                return false;
            }


            //MessageBox.Show(input + " " + formatedDate);

            return true;
        }
    }
}
