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
    }
}