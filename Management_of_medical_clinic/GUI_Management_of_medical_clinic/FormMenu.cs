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

            List<EmployeeModel> employees = EmployeeService.GetEmployeesData();

            foreach(EmployeeModel emp in employees)
            {
                FormEmployeeList employeeList = new FormEmployeeList(emp);
                //this.Hide();
                employeeList.ShowDialog();
                this.Close();
                /*
                if(emp.Username==login && emp.Password == password)
                {
                    FormEmployeeList employeeList = new FormEmployeeList(emp);
                    //this.Hide();
                    employeeList.ShowDialog();
                    this.Close();
                }
                */

            }

            MessageBox.Show("Incorrect login or password");
 
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}