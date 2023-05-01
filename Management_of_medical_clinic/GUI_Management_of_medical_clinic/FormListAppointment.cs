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
            DisplayDataInDataGridView();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            this.Hide();
            formCalendarAppointment.ShowDialog();
            this.Close();
        }

        #region // Display data

        private void DisplayDataInDataGridView()
        {
            dataGridViewAppointmentList.Rows.Clear();
            List<AppointmentModel> appointments = CalendarAppointmentService.GetAppointmentsData();

            

            foreach (AppointmentModel appointment in appointments)
            {
                if(appointment.PatientId != null && appointment.IsActive == true)
                {
                    int index = dataGridViewAppointmentList.Rows.Add(appointment.appointmentData);
                    dataGridViewAppointmentList.Rows[index].Tag = appointment;
                }
            }
        }
        #endregion

    }
}
