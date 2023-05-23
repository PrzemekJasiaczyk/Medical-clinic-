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

            comboboxPatient_add();
            comboboxDoctor_add();

            this.appointment = appointment;
            this.currentUser = user;
        }

        public FormRegisterAppointment(EmployeeModel user, DoctorsDayPlanModel appointment, bool isEdit)
        {
            InitializeComponent();

            comboboxPatient_add();
            comboboxDoctor_add();

            this.appointment = appointment;
            this.currentUser = user;
            this.isEdit = isEdit;
            
        }


        private void FormRegisterAppointment_Load(object sender, EventArgs e)
        {
            if (appointment != null && isEdit==false)
            {
                OnlyReadDoctorAndDateComboBox();
                SelectDateInCombo();
                SelectDoctorInComboBox();
            }

            if (isEdit ==true)
            {
                LockDoctorAndPatientComboBox();
                SelectPatientInComboBox();
                SelectDoctorInComboBox();
                //AddAvailableTermsToComboForDoctor();
                ChangeLabelWithNameOfForm();
            }


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

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();

        }


        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckIfAllComboBoxesAreSelected()
        {
            if (comboBoxPatient.SelectedIndex == -1 ||
                comboBoxDoctor.SelectedIndex == -1 ||
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
            
            if (comboBoxPatient.SelectedItem != null)
            {
                Patient selectedPatient = (Patient)comboBoxPatient.SelectedItem;
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


            if(isEdit == true)
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
            if(isEdit == false)
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
            comboBoxDoctor.Enabled = false;
        }


        private void ChangeLabelWithNameOfForm()
        {
            DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);

            labelTitle.Text = "Changing the date of the visit from: " + date.ToShortDateString();
        }

        private void LockDoctorAndPatientComboBox()
        {
            comboBoxDoctor.Enabled = false;
            comboBoxPatient.Enabled = false;
        }

        private void SelectPatientInComboBox()
        {
            Patient patient = new Patient();
            patient = PatientService.GetPatientById((int)appointment.PatientId);


            comboBoxPatient.Items.Clear();
            comboBoxPatient.Items.Add(patient);

            comboBoxPatient.SelectedIndex = 0;
        }

        private void SelectDoctorInComboBox()
        {
            comboBoxDoctor.Items.Clear();
            EmployeeModel employee = new EmployeeModel();
            employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);

            comboBoxDoctor.Items.Add(employee);
            comboBoxDoctor.SelectedIndex = 0;
        }

        private void SelectDateInCombo()
        {
            comboBoxDate.Items.Clear();
            comboBoxDate.Items.Add(appointment);
            comboBoxDate.SelectedItem = appointment;
        }

        #endregion

    }
}
