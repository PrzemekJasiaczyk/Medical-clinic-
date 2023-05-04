using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

//The system allows to filter patients on: 

//Name and the surname of patient. x 

//The PESEL number x

//Date of the visit x 

//Doctor specialization x

//Doctor name/surname x


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

            AddItemsToTheComboBoxDoctorOrPatient();
            AddItemsToComboBoxSpecialization();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            this.Hide();
            formCalendarAppointment.ShowDialog();
            this.Close();
        }

        #region Display data

        private void DisplayDataInDataGridView(List<AppointmentModel> appointments)
        {
            dataGridViewAppointmentList.Rows.Clear();

            foreach (AppointmentModel appointment in appointments)
            {
                int index = dataGridViewAppointmentList.Rows.Add(appointment.appointmentData);
                dataGridViewAppointmentList.Rows[index].Tag = appointment;
            }
        }

        enum DoctorOrPatient { Patient, Doctor }

        private void AddItemsToTheComboBoxDoctorOrPatient()
        {
            comboBoxSelectDoctorOrPatient.Items.Clear();
            comboBoxSelectDoctorOrPatient.Items.Add(DoctorOrPatient.Patient);
            comboBoxSelectDoctorOrPatient.Items.Add(DoctorOrPatient.Doctor);

            comboBoxSelectDoctorOrPatient.SelectedIndex = 0;
        }

        private void AddItemsToComboBoxSpecialization()
        {
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();

            foreach (SpecializationModel specialization in specializations)
            {
                int index = comboBoxDoctorSpecialization.Items.Add(specialization.ToString());
                comboBoxDoctorSpecialization.Items[index] = specialization;
            }
        }

        #endregion

        #region Filtr data

        private List<AppointmentModel> FiltrByName(List<AppointmentModel> appointments)
        {
            List<AppointmentModel> result = new List<AppointmentModel>();
            string checkedString = textBoxName.Text.ToLower();

            if (textBoxName.Text == string.Empty)
            {
                return appointments;
            }

            string PatientOrDoctor = SelectedInComboBoxIsDoctorOrPatient();

            string name = string.Empty;

            foreach (AppointmentModel appointment in appointments)
            {

                if (PatientOrDoctor == "Patient")
                {
                    Patient patient = CalendarAppointmentService.GetPatientDataByIdPatient(appointment);
                    name = patient.FirstName.ToLower();

                    if (name.StartsWith(checkedString))
                    {
                        result.Add(appointment);
                    }
                }
                else
                {
                    EmployeeModel employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);
                    name = employee.FirstName.ToLower();

                    if (name.StartsWith(checkedString))
                    {
                        result.Add(appointment);
                    }
                }
            }
            return result;
        }

        private List<AppointmentModel> FiltrByLastName(List<AppointmentModel> appointments)
        {
            string checkedValue = textBoxLastName.Text.ToLower();

            if (textBoxLastName.Text == string.Empty)
            {
                return appointments;
            }

            List<AppointmentModel> result = new List<AppointmentModel>();

            string PatientOrDoctor = SelectedInComboBoxIsDoctorOrPatient();
            string name = string.Empty;

            foreach (AppointmentModel appointment in appointments)
            {

                if (PatientOrDoctor == "Patient")
                {
                    Patient patient = CalendarAppointmentService.GetPatientDataByIdPatient(appointment);
                    name = patient.LastName.ToLower();

                    if (name.StartsWith(checkedValue))
                    {
                        result.Add(appointment);
                    }
                }
                else
                {
                    EmployeeModel employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);
                    name = employee.LastName.ToLower();

                    if (name.StartsWith(checkedValue))
                    {
                        result.Add(appointment);
                    }
                }
            }

            return result;
        }


        private List<AppointmentModel> FiltrByPESEL(List<AppointmentModel> appointments)
        {
            string checkedValue = maskedTextBoxPESEL.Text;

            if (checkedValue == string.Empty)
            {
                return appointments;
            }

            List<AppointmentModel> result = new List<AppointmentModel>();

            foreach (AppointmentModel appointment in appointments)
            {
                Patient patient = PatientService.GetPatientById((int)appointment.PatientId);

                if (patient.PESEL.StartsWith(checkedValue))
                {
                    result.Add(appointment);
                }
            }
            return result;
        }


        private List<AppointmentModel> FiltrByVisit(List<AppointmentModel> appointments)
        {
            DateTime checkedValue = dateTimePickerDateOfVisit.Value.Date;

            if (!checkBoxDateOfVisit.Checked)
            {
                return appointments;
            }

            List<AppointmentModel> result = new List<AppointmentModel>();

            DateTime date;

            foreach (AppointmentModel appointment in appointments)
            {
                result = CalendarAppointmentService.appointmentInSelectedDate(appointments, checkedValue, (int)appointment.IdCalendar);
                //?            
            }

            return result;
        }


        private List<AppointmentModel> FiltrBySpecialization(List<AppointmentModel> appointments)
        {
            if (comboBoxDoctorSpecialization.SelectedIndex == -1)
            {
                return appointments;
            }

            List<AppointmentModel> result = new List<AppointmentModel>();

            SpecializationModel checkedValue = (SpecializationModel)comboBoxDoctorSpecialization.SelectedItem;

            int idSpecialization = checkedValue.IdSpecialization;

            EmployeeModel employee = new EmployeeModel();


            foreach (AppointmentModel appointment in appointments)
            {
                employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);

                if (employee.IdSpecialization == idSpecialization)
                {
                    result.Add(appointment);
                }
            }

            return result;

        }

        private string SelectedInComboBoxIsDoctorOrPatient()
        {
            string result = string.Empty;
            if (comboBoxSelectDoctorOrPatient.SelectedIndex == 0) // Patient
            {
                result = "Patient";
            }
            else if (comboBoxSelectDoctorOrPatient.SelectedIndex == 1) //Doctor
            {
                result = "Doctor";
            }

            return result;
        }

        #endregion

        private void buttonAddFiltr_Click(object sender, EventArgs e)
        {
            dataGridViewAppointmentList.Rows.Clear();

            List<AppointmentModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();

            List<AppointmentModel> result = new List<AppointmentModel>();

            result = FiltrByName(appointments);
            result = FiltrByLastName(result);
            result = FiltrByPESEL(result);
            result = FiltrBySpecialization(result);
            result = FiltrByVisit(result);

            DisplayDataInDataGridView(result);
        }

        private void buttonClearFiltr_Click(object sender, EventArgs e)
        {
            List<AppointmentModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();
            DisplayDataInDataGridView(appointments);

            comboBoxDoctorSpecialization.SelectedIndex = -1;
            comboBoxSelectDoctorOrPatient.SelectedIndex = 0;

            textBoxLastName.Text = string.Empty;
            textBoxName.Text = string.Empty;
            maskedTextBoxPESEL.Text = string.Empty;
            dateTimePickerDateOfVisit.Value = DateTime.Today;
            checkBoxDateOfVisit.Checked = false;
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentList.Rows.Count == 0)
            {
                string msg = "No appointments. Register an appointment.";
                FormMessage FormMessage = new FormMessage(msg);
                FormMessage.ShowDialog();
                return;
            }

            AppointmentModel appointment = (AppointmentModel)dataGridViewAppointmentList.SelectedRows[0].Tag;

            FormShowDetailsAppointment formShowDetailsAppointment = new FormShowDetailsAppointment(currentUser, appointment);
            Hide();
            formShowDetailsAppointment.ShowDialog();
            Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentList.Rows.Count == 0)
            {
                string msg1 = "No appointments. Register an appointment.";
                FormMessage FormMessage1 = new FormMessage(msg1);
                FormMessage1.ShowDialog();
                return;
            }
       
            AppointmentModel appointment = (AppointmentModel)dataGridViewAppointmentList.SelectedRows[0].Tag;
            DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);
            string term = AppointmentService.GetTermByTermId((int)appointment.IdTerm);
            TimeSpan time = TimeSpan.ParseExact(term, "hh\\:mm", null);

            if (date <= DateTime.Now.Date && time <= DateTime.Now.TimeOfDay)
            {
                string msg2 = "You cannot cancel an appointment from the past.";
                FormMessage FormMessage2 = new FormMessage(msg2);
                FormMessage2.ShowDialog();
                return;
            }

            FormConfirmCancelAppointment cancel = new FormConfirmCancelAppointment(currentUser, appointment);
            cancel.ShowDialog();
        }
    }
}
