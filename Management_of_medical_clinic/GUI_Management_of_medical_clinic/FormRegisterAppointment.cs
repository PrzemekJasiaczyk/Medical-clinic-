using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Migrations;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormRegisterAppointment : Form
    {
        private PatientService patientService;
        EmployeeModel currentUser;
        public AppointmentService appointmentService;

        bool isEdit;

        DoctorsDayPlanModel appointment;

        public FormRegisterAppointment(EmployeeModel user, DoctorsDayPlanModel? appointment)
        {
            InitializeComponent();
            dataGridView_app_doctor.ClearSelection();
            DisplayDoctor();
            DisplayPatient();


            this.appointment = appointment;
            this.currentUser = user;
        }

        public FormRegisterAppointment(EmployeeModel user, DoctorsDayPlanModel appointment, bool isEdit)
        {
            InitializeComponent();
            dataGridView_app_doctor.ClearSelection();


            DisplayDoctor();
            DisplayPatient();

            this.appointment = appointment;
            this.currentUser = user;
            this.isEdit = isEdit;

        }

        public void DisplayDoctor()
        {
            List<EmployeeModel> employees = EmployeeService.GetEmployeesData()
                .Where(d => d.Role == EnumEmployeeRoles.MedicalDoctor)
                .ToList();

            dataGridView_app_doctor.DataSource = employees;
            dataGridView_app_doctor.Columns[0].Visible = false;
            dataGridView_app_doctor.Columns[3].Visible = false;
            dataGridView_app_doctor.Columns[4].Visible = false;
            dataGridView_app_doctor.Columns[5].Visible = false;
            dataGridView_app_doctor.Columns[6].Visible = false;
            dataGridView_app_doctor.Columns[7].Visible = false;
            dataGridView_app_doctor.Columns[8].Visible = false;
            dataGridView_app_doctor.Columns[9].Visible = false;
            dataGridView_app_doctor.Columns[11].Visible = false;
            dataGridView_app_doctor.Columns[10].Visible = false;
            dataGridView_app_doctor.Columns[13].Visible = false;
        }

        public void DisplayPatient()
        {
            List<Patient> patients = PatientService.GetPatientsData();

            dataGridView_app_Patient.DataSource = patients;
            dataGridView_app_Patient.Columns[0].Visible = false;
            dataGridView_app_Patient.Columns[4].Visible = false;
            dataGridView_app_Patient.Columns[5].Visible = false;
            dataGridView_app_Patient.Columns[6].Visible = false;








        }


        private void FormRegisterAppointment_Load(object sender, EventArgs e)
        {
            if (appointment != null && isEdit == false)
            {
                OnlyReadDoctorAndDateComboBox();
                SelectDateInCombo();
                SelectDoctorInComboBox();
            }

            if (isEdit == true)
            {
                LockDoctorAndPatientComboBox();
                SelectPatientInComboBox();
                SelectDoctorInComboBox();
                ChangeLabelWithNameOfFormAndButton();
            }


        }



        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();

        }


        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckIfAllComboBoxesAreSelected()
        {
            if (
                comboBoxDate.SelectedIndex == -1)
            {
                buttonAddAppointment.Enabled = false;
            }
            else
            {
                buttonAddAppointment.Enabled = true;
            }
        }

        private void comboBoxPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();
        }

        private void comboBoxDoctor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            int selectedAppointmentId = -1;
            int selectedPatientId = -1;

            if (comboBoxDate.SelectedItem != null)
            {
                DoctorsDayPlanModel selectedAppointment = (DoctorsDayPlanModel)comboBoxDate.SelectedItem;
                selectedAppointmentId = selectedAppointment.IdDoctorsDayPlan;
            }

            if (dataGridView_app_Patient.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView_app_Patient.SelectedRows[0];
                Patient selectedPatient = (Patient)selectedRow.DataBoundItem;
                selectedPatientId = selectedPatient.PatientId;
            }

            using (AppDbContext db = new AppDbContext())
            {
                DoctorsDayPlanModel? appointment = db.DbDoctorsDayPlan.FirstOrDefault(a => a.IdDoctorsDayPlan == selectedAppointmentId);

                if (appointment != null)
                {
                    appointment.PatientId = selectedPatientId;
                    appointment.Status = EnumAppointmentStatus.Scheduled;
                    db.Entry(appointment).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }


            if (isEdit == true)
            {
                DoctorsPlanService.RemovePatientFromPlan(appointment);

                FormListAppointment form = new FormListAppointment(currentUser);
                Hide();
                form.ShowDialog();
                Close();

            }

            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            formCalendarAppointment.ShowDialog();
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (isEdit == false)
            {
                FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
                this.Hide();
                formCalendarAppointment.ShowDialog();
                this.Close();
            }
            else
            {
                FormListAppointment form = new FormListAppointment(currentUser);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }


        }

        #region Function
        private void OnlyReadDoctorAndDateComboBox()
        {
            comboBoxDate.Enabled = false;
            //comboBoxDoctor.Enabled = false;
        }


        private void ChangeLabelWithNameOfFormAndButton()
        {
            DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);

            String hour = DoctorsPlanService.GetTermDescription((EnumTerms)appointment.IdOfTerm);

            labelTitle.Text = "Changing the date of the visit from: " + date.ToShortDateString() + " hour: " + hour;
            buttonAddAppointment.Text = "Reschedule";
        }

        private void LockDoctorAndPatientComboBox()
        {
            //comboBoxDoctor.Enabled = false;
            //comboBoxPatient.Enabled = false;
        }

        private void SelectPatientInComboBox()
        {
            Patient patient = new Patient();
            patient = PatientService.GetPatientById((int)appointment.PatientId);


            //comboBoxPatient.Items.Clear();
            // comboBoxPatient.Items.Add(patient);

            //comboBoxPatient.SelectedIndex = 0;
        }

        private void SelectDoctorInComboBox()
        {
            // comboBoxDoctor.Items.Clear();
            EmployeeModel employee = new EmployeeModel();
            employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);

            // comboBoxDoctor.Items.Add(employee);
            //comboBoxDoctor.SelectedIndex = 0;
        }

        private void SelectDateInCombo()
        {
            comboBoxDate.Items.Clear();
            comboBoxDate.Items.Add(appointment);
            comboBoxDate.SelectedItem = appointment;
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_app_Patient_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void dataGridView_app_Patient_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_app_doctor_SelectionChanged(object sender, EventArgs e)
        {
            int selectedDoctorId = 0;
            /*
            if (dataGridView_app_doctor.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView_app_doctor.SelectedRows[0];
                EmployeeModel doc = (EmployeeModel)selectedRow.DataBoundItem;
                //selectedAppointmentId = selectedAppointment.IdDoctorsDayPlan;
                //EmployeeModel doc = (EmployeeModel)comboBoxDoctor.SelectedItem;
                selectedDoctorId = doc.IdEmployee;
            }
            */

            if (dataGridView_app_doctor.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView_app_doctor.SelectedRows[0];
                EmployeeModel id = (EmployeeModel)dataGridView_app_doctor.SelectedRows[0].DataBoundItem;
                selectedDoctorId = id.IdEmployee;
            }

            List<DoctorsDayPlanModel> appointments =
            CalendarAppointmentService.GetAppointmentsData()
                .Where(a => a.IdEmployee == selectedDoctorId && a.Status == EnumAppointmentStatus.Accepted && a.PatientId == null)
                .ToList();

            comboBoxDate.Items.Clear();
            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                comboBoxDate.Items.Add(appointment);
            }
            comboBoxDate.DisplayMember = appointments.ToString();
        }

        private void buttonShowFilters_Click(object sender, EventArgs e)
        {
            PatientService patientService = new PatientService();
            List<Patient> FiltredPatients = patientService.FilterPatient(textBox1_Name.Text, TextBox_PESEL.Text);
            dataGridView_app_Patient.DataSource = FiltredPatients;
        }

        public List<EmployeeModel> FilterDoctor(string searchedText)
        {
            List<EmployeeModel> filteredDoctors = EmployeeService.GetEmployeesData();

            if (!string.IsNullOrEmpty(searchedText))
            {
                searchedText = searchedText.ToLower();

                filteredDoctors =
                    filteredDoctors
                    .Where(
                        p =>
                        (p.FirstName + " " + p.LastName)
                            .ToLower()
                            .Contains(searchedText)
                        )
                    .ToList();
            }



            return filteredDoctors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EmployeeModel> FiltredDoctors = FilterDoctor(textBox1_doctor.Text);
            dataGridView_app_doctor.DataSource = FiltredDoctors;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayPatient();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayDoctor();
        }
    }
}
