using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System.Collections.Generic;


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
            List<AppointmentModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();
            DisplayDataInDataGridView(appointments);
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            this.Hide();
            formCalendarAppointment.ShowDialog();
            this.Close();
        }

        #region // Display data

        private void DisplayDataInDataGridView(List<AppointmentModel> appointments)
        {
            dataGridViewAppointmentList.Rows.Clear();

            foreach (AppointmentModel appointment in appointments)
            {
                int index = dataGridViewAppointmentList.Rows.Add(appointment.appointmentData);
                dataGridViewAppointmentList.Rows[index].Tag = appointment;
            }
        }

        #endregion


        

    }
}
