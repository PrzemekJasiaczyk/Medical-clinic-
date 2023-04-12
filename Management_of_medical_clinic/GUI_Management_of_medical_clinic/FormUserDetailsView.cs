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
    public partial class FormUserDetailsView : Form
    {
        EmployeeModel currentUser;
        UserModel user;

        public FormUserDetailsView()
        {
            InitializeComponent();
        }

        public FormUserDetailsView(UserModel user, EmployeeModel currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.user = user;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FormUserDetailsView_Load(object sender, EventArgs e)
        {
            textBoxEmployeeId.Text = user.IdEmployee.ToString();
            textBoxUserId.Text = user.IdUser.ToString();
            textBoxUsername.Text = user.Username;
            textBoxRole.Text = user.Role.ToString();
            textBoxActive.Text = user.IsActive ? "Active" : "Disactive";
        }
    }
}
