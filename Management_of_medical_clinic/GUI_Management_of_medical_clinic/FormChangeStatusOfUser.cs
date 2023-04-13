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

        public FormChangeStatusOfUser()
        {
            InitializeComponent();
        }

        public FormChangeStatusOfUser(UserModel user, EmployeeModel currentUser)
        {
            this.user = user;
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormUserList formUserList = new FormUserList(currentUser);
            formUserList.ShowDialog();
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == UserService.GetUserByEmployeeId(currentUser).Password)
            {
                UserModel.ChangeUserStatus(user);
                FormUserList userList = new FormUserList(currentUser);
                userList.ShowDialog();
                Close();
            }
        }
    }
}
