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
    public partial class FormEmployeeDetailsView : Form
    {
        EmployeeModel employee;
        EmployeeModel currentUser;
        public FormEmployeeDetailsView(EmployeeModel emp, EmployeeModel currentU)
        {
            InitializeComponent();
            employee = emp;
            currentUser = currentU;
        }

        private void FormEmployeeDetailsView_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxPESEL.Text = employee.PESEL;
            textBoxDateOfBirth.Text = employee.DateOfBirth.ToString();
            textBoxRole.Text = employee.Role.ToString();
            textBoxCorrespondenceAddress.Text = employee.CorrespondenceAddress;
            textBoxEmail.Text = employee.Email;
            textBoxPhoneNumber.Text = employee.PhoneNumber;
            textBoxSex.Text = employee.Sex.ToString();
            textBoxIsActive.Text = employee.IsActive.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList(currentUser);
            Hide();
            employeeList.ShowDialog();
            Close();
        }

        private void Edit_Employee_Click(object sender, EventArgs e)
        {
            FormEmployeeEdit employeeEdit = new FormEmployeeEdit(employee, currentUser);
            Hide();
            employeeEdit.ShowDialog();
            Close();
        }

        private void textBoxRole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
