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
    public partial class FormChangeStatusOfUser : Form
    {
        UserModel user;
        EmployeeModel currentUser;

        public FormChangeStatusOfUser(UserModel usr, EmployeeModel currentU)
        {
            InitializeComponent();
            user = usr;
            currentUser = currentU;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            UserModel userFromCurrentUser = UserService.GetUserByEmployeeId(currentUser);   // pobieram id usera od currentUsera(EmployeeModel)
            if (textBoxPassword.Text != userFromCurrentUser.Password)
            {
                MessageBox.Show("Invalid password!");
                return;
            }

            UserModel.ChangeUserStatus(user);

            List<Form> otwarteOkna = new List<Form>(Application.OpenForms.Cast<Form>());
            
            foreach (Form otwarteOkno in otwarteOkna)
            {
                otwarteOkno.Hide();
            }

            FormUserList formUserList = new FormUserList(currentUser);
            formUserList.ShowDialog();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormUserList formEmployeeList = new FormUserList(currentUser);
            this.Hide();
            formEmployeeList.ShowDialog();
            this.Close();
        }
    }
}
