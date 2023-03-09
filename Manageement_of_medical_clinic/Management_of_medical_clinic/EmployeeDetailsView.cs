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
    public partial class EmployeeDetailsView : Form
    {
        Employee employee;
        public EmployeeDetailsView(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }

        private void EmployeeDetailsView_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxPESEL.Text = employee.PESEL;
            textBoxDateOfBirth.Text = employee.DateOfBirth.ToString();
            textBoxRole.Text = employee.Role;
            textBoxCorrespondenceAddress.Text = employee.CorrespondenceAddress;
            textBoxEmail.Text = employee.Email;
            textBoxPhoneNumber.Text = employee.PhoneNumber;
            textBoxSex.Text = employee.Sex.ToString();
            textBoxIsActive.Text = employee.IsActive.ToString();
        }

        private void EmployeeDetailsView_Load_1(object sender, EventArgs e)
        {
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxPESEL.Text = employee.PESEL;
            textBoxDateOfBirth.Text = employee.DateOfBirth.ToString();
            textBoxRole.Text = employee.Role;
            textBoxCorrespondenceAddress.Text = employee.CorrespondenceAddress;
            textBoxEmail.Text = employee.Email;
            textBoxPhoneNumber.Text = employee.PhoneNumber;
            textBoxSex.Text = employee.Sex.ToString();
            textBoxIsActive.Text = employee.IsActive.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }
    }
}
