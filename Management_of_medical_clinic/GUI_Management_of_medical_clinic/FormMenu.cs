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
            FormEmployeeList employeeList = new FormEmployeeList();
            this.Hide();
            employeeList.ShowDialog();
            this.Close();
        }
    }
}