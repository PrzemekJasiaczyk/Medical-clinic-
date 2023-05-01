using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;


//Filter list of appointments 

//As a medical clinic staff member 

//I want to filter the list of appointments 

//So that I can see only the chosen data on the list. 

//Acceptance criteria:  

//The system allows to filter patients on: 

//Name and the surname of patient. 

//The PESEL number 

//Date of the visit 

//Doctor specialization 

//Doctor name/surname 



//Sort list of patients 

//As a patient management staff 

//I want to have possibility to organize data on the list 

//So that the order of presented data will be changing. 

//Acceptance criteria:  

//The system allows sorting the list from: 

//Alphabetically ascending 

//Alphabetically descending 


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
                if (appointment.PatientId != null && appointment.IsActive == true)
                {
                    int index = dataGridViewAppointmentList.Rows.Add(appointment.appointmentData);
                    dataGridViewAppointmentList.Rows[index].Tag = appointment;
                }
            }
        }
        #endregion


        #region // Sort data

        private List<AppointmentModel> SortedAppointmentList() 
        {
            dataGridViewAppointmentList.Rows.Clear();
            List<AppointmentModel> appointments = CalendarAppointmentService.GetAppointmentsData();
            List<AppointmentModel> result = (List<AppointmentModel>)appointments.OrderBy(a => a.IdEmployee);

            return result;

        }

        #endregion

        private void pictureBoxSortASC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSortDESC_Click(object sender, EventArgs e)
        {

        }
    }
}
