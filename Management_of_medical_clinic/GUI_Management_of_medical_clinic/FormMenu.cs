using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();         
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panelLogIn.BackColor = Color.FromArgb(150, Color.Gray);
        }

        private void buttonOpenEmployeeList_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            List<UserModel> users = UserService.GetUsersData();

            foreach (UserModel user in users)
            {

                if (user.Username == login && user.Password == password)

                {
                    EmployeeModel employee = EmployeeService.GetEmployeeByUserId(user);
                    if (employee != null)
                    {
                        FormEmployeeList employeeList = new FormEmployeeList(employee);
                        this.Hide();
                        employeeList.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User isn't linked to an employee account\nLog in unsuccessful");
                        return;
                    }
                }
            }

            MessageBox.Show("Incorrect login or password");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenUserList_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            List<UserModel> users = UserService.GetUsersData();

            foreach (UserModel user in users)
            {

                if (user.Username == login && user.Password == password)

                {
                    EmployeeModel employee = EmployeeService.GetEmployeeByUserId(user);
                    if (employee != null)
                    {
                        FormUserList userList = new FormUserList();
                        //this.Hide();
                        userList.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User isn't linked to an employee account\nLog in unsuccessful");
                        return;
                    }
                }
            }

            MessageBox.Show("Incorrect login or password");
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            checkIfDataFilled();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            checkIfDataFilled();
        }

        public void checkIfDataFilled()
        {
            if (textBoxLogin.Text.Length>0 && textBoxPassword.Text.Length > 0)
            {
                buttonOpenEmployeeList.Enabled = true;
                buttonOpenUserList.Enabled = true;
                buttonOpenEmployeeList.BackColor = Color.SteelBlue;
                buttonOpenUserList.BackColor = Color.SteelBlue;

            }
            else
            {
                buttonOpenEmployeeList.Enabled = false;
                buttonOpenUserList.Enabled = false;
                buttonOpenEmployeeList.BackColor = Color.Gray;
                buttonOpenUserList.BackColor = Color.Gray;
            }
        }
    }
}