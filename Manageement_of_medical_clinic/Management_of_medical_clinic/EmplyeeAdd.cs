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
            validatePESEL();
            validateEmail();
            validatePhone();
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


        //Validate PESEL input
        public bool validatePESEL()
        {
            string input = textBoxPESEL.Text;
            string firstSix = input.Substring(0, 6);

            DateTime selectedDate = dateTimePickerDate.Value;
            string formatedDate = selectedDate.ToString("dd/MM/yy");
            string rawDate = formatedDate.Replace("/", "");

            int currentIndex = comboBoxSex.SelectedIndex;

            if (input.Length != 11)
            {
                MessageBox.Show("PESEL should be 11 digits long");
                return false;                
            }

            if (!long.TryParse(input, out long result))
            {
                MessageBox.Show("PESEL can only contain digits");
                return false;                
            }

            if(firstSix != rawDate)
            {
                MessageBox.Show("PESEL doesn't fit the date of birth");
                return false;                
            }

            if (currentIndex == 1 && input.Substring(input.Length - 2, 1)[0]%2==0)
            {
                MessageBox.Show("PESEL doesn't fit the sex");
                return false;
            }

            if (currentIndex == 2 && input.Substring(input.Length - 2, 1)[0] % 2 == 1)
            {
                MessageBox.Show("PESEL doesn't fit the sex");
                return false;
            }

            return true;
        }


        //Validate Email input
        public bool validateEmail()
        {

            string input = textBoxEmail.Text;
            int atIndex = input.IndexOf('@');
            int dotIndex = input.LastIndexOf('.');


            if (input.Length > 0) 
            { 
                if (input.Count(c => c == '@')!=1)
                {
                    MessageBox.Show("E-mail has to contain one '@' sign");
                    return false;
                }

                if (!input.Contains("."))
                {
                    MessageBox.Show("E-mail has to contain at least only '.' sign");
                    return false;
                }

                
                if (atIndex < 1 || atIndex == input.Length - 1)
                {
                    MessageBox.Show("The '@' sign has to have characers in front and behind of it");
                    return false;
                }

                
                if (dotIndex < atIndex + 2 || dotIndex == input.Length - 1)
                {
                    MessageBox.Show("The last '.' sign has to have characters behind and after it,\nand it has to be after the '@' sign");
                    return false;
                }
            }

            return true;
        }


        //Validate Phone Number input
        public bool validatePhone()
        {
            string input = textBoxPhone.Text;

            if (input.Length > 0)
            {
                if (input.Length != 9)
                {
                    MessageBox.Show("Phone number has to be 9 digits long");
                    return false;
                }

                if (!long.TryParse(input, out long result))
                {
                    MessageBox.Show("Phone number can only contain digits");
                    return false;
                }
            }

            return true;
        }
    }
}
