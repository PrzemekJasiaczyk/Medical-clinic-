﻿using Console_Management_of_medical_clinic.Data;
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
            List<AppointmentModel> appointments = CalendarAppointmentService.GetFreeAppointments();
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
                if (appointment.PatientId != null && appointment.IsActive == true)
                {
                    int index = dataGridViewAppointmentList.Rows.Add(appointment.appointmentData);
                    dataGridViewAppointmentList.Rows[index].Tag = appointment;
                }
            }
        }

        #endregion


        #region // Sort data

        private List<AppointmentModel> SortedAppointmentListASC()
        {
            List<AppointmentModel> appointments = CalendarAppointmentService.GetFreeAppointments();
            List<AppointmentModel> result = (List<AppointmentModel>)appointments.OrderBy( a => a.EmployeeModel.LastName);
            return result;
        }

        private List<AppointmentModel> SortedAppointmentListDESC()
        {
            List<AppointmentModel> appointments = CalendarAppointmentService.GetFreeAppointments();
            List<AppointmentModel> result = (List<AppointmentModel>)appointments.OrderByDescending(a => a.IdEmployee);

            return result;

        }
        #endregion

        private void pictureBoxSortASC_Click(object sender, EventArgs e)
        {
            List<AppointmentModel> appointments = SortedAppointmentListASC();
            DisplayDataInDataGridView(appointments);
        }

        private void pictureBoxSortDESC_Click(object sender, EventArgs e)
        {
            List<AppointmentModel> appointments = SortedAppointmentListDESC();
            DisplayDataInDataGridView(appointments);
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            AppDbContext _context = new AppDbContext();
            AppointmentModel appointment = (AppointmentModel)dataGridViewAppointmentList.SelectedRows[0].Tag; ;
            FormShowDetailsAppointment formShowDetailsAppointment = new FormShowDetailsAppointment(currentUser, appointment);
            Hide();
            formShowDetailsAppointment.ShowDialog();
            Close();
        }
    }
}
