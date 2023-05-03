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

        AppointmentModel appointment;

        public FormRegisterAppointment(EmployeeModel user, AppointmentModel? appointment)
        {
            InitializeComponent();

            comboboxPatient_add();
            comboboxDoctor_add();

            this.appointment = appointment;
            this.currentUser = user;
        }

        private void FormRegisterAppointment_Load(object sender, EventArgs e)
        {
            if(appointment==null) return;

            OnlyReadControls();
            SelectDataInCombo();

        }

        void comboboxPatient_add()
        {
            comboBoxPatient.Items.Clear();
            List<Patient> patients =
            PatientService.GetPatientsData();
            comboBoxPatient.Items.Clear();
            foreach (Patient patient in patients)
            {
                comboBoxPatient.Items.Add(patient);
            }
            comboBoxPatient.DisplayMember = patients.ToString();
        }

        void comboboxDoctor_add()
        {
            comboBoxDoctor.Items.Clear();
            List<EmployeeModel> employees =
            EmployeeService.GetEmployeesData()
             .Where(d => d.Role == EnumEmployeeRoles.MedicalDoctor)
             .ToList();
            comboBoxDoctor.Items.Clear();
            foreach (EmployeeModel employee in employees)
            {
                comboBoxDoctor.Items.Add(employee);
            }
            comboBoxPatient.DisplayMember = employees.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDate.SelectedIndex = -1;
            comboBoxDate.Items.Clear();
            int selectedDoctorId = -1;
            if (comboBoxDoctor.SelectedItem != null)
            {
                EmployeeModel doc = (EmployeeModel)comboBoxDoctor.SelectedItem;
                selectedDoctorId = doc.IdEmployee;
            }
            List<AppointmentModel> appointments =
            CalendarAppointmentService.GetAppointmentsData()
                .Where(a => a.IdEmployee == selectedDoctorId && a.IsActive == true && a.PatientId == null)
                .ToList();
            comboBoxDate.Items.Clear();
            foreach (AppointmentModel appointment in appointments)
            {
                comboBoxDate.Items.Add(appointment);
            }
            comboBoxDate.DisplayMember = appointments.ToString();

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
            if (comboBoxPatient.SelectedIndex == -1 &&
                comboBoxDoctor.SelectedIndex == -1 &&
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
            if (comboBoxDate.SelectedItem != null)
            {
                AppointmentModel selectedAppointment = (AppointmentModel)comboBoxDate.SelectedItem;
                selectedAppointmentId = selectedAppointment.IdAppointment;
            }
            int selectedPatientId = -1;
            if (comboBoxPatient.SelectedItem != null)
            {
                Patient selectedPatient = (Patient)comboBoxPatient.SelectedItem;
                selectedPatientId = selectedPatient.PatientId;
            }

            using (AppDbContext db = new AppDbContext())
            {
                AppointmentModel? appointment = db.DbAppointments.FirstOrDefault(a=>a.IdAppointment==selectedAppointmentId);
                


                if (appointment != null)
                {
                    appointment.PatientId = selectedPatientId;
                    appointment.IsActive = false;
                    db.Entry(appointment).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            formCalendarAppointment.ShowDialog();
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            this.Hide();
            formCalendarAppointment.ShowDialog();
            this.Close();
        }

        #region Function
        private void OnlyReadControls()
        {
            comboBoxDate.Enabled = false;
            comboBoxDoctor.Enabled = false;    
        }

        private void SelectDataInCombo()
        {
            comboBoxDoctor.Items.Clear();

            comboBoxDoctor.Items.Add(EmployeeService.GetEmployeeByID((int)appointment.IdEmployee));
            comboBoxDoctor.SelectedIndex = 0;

            comboBoxDate.Items.Clear();

            comboBoxDate.Items.Add(appointment);
            comboBoxDate.SelectedItem = appointment;
        }

        #endregion

    }
}
