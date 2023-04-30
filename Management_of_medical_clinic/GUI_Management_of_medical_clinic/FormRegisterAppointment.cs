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
        public AppointmentService appointmentService;
        string selectedDoctor;
        string selectedPatient;
        string selectedDate;

        public FormRegisterAppointment()
        {
            InitializeComponent();
            comboBoxPatient.Items.AddRange(GetPatientNames().ToArray());
            comboBoxDoctor.Items.AddRange(GetDoctorNames().ToArray());


        }

        private void FormRegisterAppointment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDate.SelectedIndex = -1;
            comboBoxDate.Items.Clear();
            selectedDoctor = comboBoxDoctor.SelectedItem.ToString();
            comboBoxDate.Items.AddRange(GetAppointments(EmployeeService.GetDoctorId(selectedDoctor)).ToArray());
        }

        public List<string> GetPatientNames()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients
                    .OrderBy(p => p.LastName)
                    .Select(p => p.ToString())
                    .ToList();
            }
        }

        public List<string> GetDoctorNames()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.DbEmployees
                    .Where(d => d.Role == EnumEmployeeRoles.MedicalDoctor)
                    .OrderBy(d => d.LastName)
                    .Select(d => d.ToString())
                    .ToList();
            }
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();



        }

        

        

        


        public List<string> GetAppointments(int idEmployee)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.DbAppointments
                    .Where(a => a.IdEmployee == idEmployee)
                    .Where(a => a.IsActive == true)
                    //.Where(a => a.Patient == null || a.PatientId == null)
                    //.Where(a => a.PatientId == null)
                    .Select(a => a.ToString())
                    .ToList();
            }
        }


        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDate = comboBoxDate.SelectedItem.ToString();


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
            int appointmentId = AppointmentService.GetAppointmentId(selectedDate);
            int patientId = PatientService.GetPatientId(selectedPatient);

            using (AppDbContext db = new AppDbContext())
            {
                var appointment = db.DbAppointments.FirstOrDefault(a => a.IdAppointment == appointmentId);

                if (appointment != null)
                {
                    appointment.PatientId = patientId;
                    appointment.IsActive = false;
                    db.Entry(appointment).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPatient = comboBoxPatient.SelectedItem.ToString();

        }


    }
}
