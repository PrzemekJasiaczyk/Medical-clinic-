using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Logic;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormPatientList : Form
    {
        AppDbContext _context;
        private PatientService patientService;
        EmployeeModel currentUser;

        public FormPatientList(EmployeeModel employee)
        {
            InitializeComponent();
            patientService = new PatientService();
            DisplayPatientsList();
            currentUser = employee;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBoxPesel_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPatientList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DisplayPatientsList()
        {
            dataGridViewPatientList.DataSource = patientService.GetPatientData();


        }

        public List<Patient> GetSortedPatientData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.OrderBy(p => p.LastName).ToList();
            }
        }

        private void DisplaySortedPatientData()
        {
            List<Patient> sortedPatientList = GetSortedPatientData();
            dataGridViewPatientList.DataSource = sortedPatientList;
        }

        public List<Patient> GetSortedPatientDataDSC()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.OrderByDescending(p => p.LastName).ToList();
            }
        }

        private void DisplaySortedPatientDataDSC()
        {
            List<Patient> sortedPatientList = GetSortedPatientDataDSC();
            dataGridViewPatientList.DataSource = sortedPatientList;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplaySortedPatientData();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplaySortedPatientDataDSC();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMenuPatient formMenuPatient = new FormMenuPatient(currentUser);
            this.Hide();
            formMenuPatient.ShowDialog();
            this.Close();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {

        }

        private void buttonActivatePatient_Click(object sender, EventArgs e)
        {
            _context = new AppDbContext();
            Patient patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);
            FormChangeStatusOfPatient activate = new FormChangeStatusOfPatient(patient, currentUser);
            activate.ShowDialog();
        }

        private void buttonDeactivatePatinet_Click(object sender, EventArgs e)
        {
            _context = new AppDbContext();
            Patient patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);
            FormChangeStatusOfPatient deactivate = new FormChangeStatusOfPatient(patient, currentUser);
            deactivate.ShowDialog();
        }
    }
}
