using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;

namespace Management_of_medical_clinic
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenEmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            Hide();
            employeeList.ShowDialog();
            Show();
        }
    }
}