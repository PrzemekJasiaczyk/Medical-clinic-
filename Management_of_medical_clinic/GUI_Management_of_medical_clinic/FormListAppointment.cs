using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;



namespace GUI_Management_of_medical_clinic
{
    public partial class FormListAppointment : Form
    {
        private PatientService patientService;
        EmployeeModel currentUser;

        public FormListAppointment(EmployeeModel employee)
        {
            InitializeComponent();
            patientService = new PatientService();
            currentUser = employee;
        }

        private void FormListAppointment_Load(object sender, EventArgs e)
        {

        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            this.Hide();
            formCalendarAppointment.ShowDialog();
            this.Close();
        }

    }
}
