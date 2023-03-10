using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;

namespace Management_of_medical_clinic
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(200, 10, 10, 0);
        }

        private void buttonOpenEmployeeList_Click(object sender, EventArgs e)
        {
            FormEmployeeList employeeList = new FormEmployeeList();
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}