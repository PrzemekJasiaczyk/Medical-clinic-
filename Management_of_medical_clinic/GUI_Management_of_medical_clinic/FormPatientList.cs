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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormPatientList : Form
    {
        private PatientService patientService;
        EmployeeModel currentUser;

        public FormPatientList(EmployeeModel employee)
        {
            InitializeComponent();
            patientService = new PatientService();
            DisplayPatientsList();
            currentUser = employee;
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


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DisplayPatientsList()
        {
            dataGridViewPatientList.DataSource = patientService.GetPatientData();


        }

        public List<PatientModel> GetSortedPatientData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.OrderBy(p => p.LastName).ToList();
            }
        }

        private void DisplaySortedPatientData()
        {
            List<PatientModel> sortedPatientList = GetSortedPatientData();
            dataGridViewPatientList.DataSource = sortedPatientList;
        }

        public List<PatientModel> GetSortedPatientDataDSC()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.OrderByDescending(p => p.LastName).ToList();
            }
        }

        private void DisplaySortedPatientDataDSC()
        {
            List<PatientModel> sortedPatientList = GetSortedPatientDataDSC();
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
            Hide();
            formMenuPatient.ShowDialog();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            FormAddEditPatient formAddEditPatient = new FormAddEditPatient(currentUser, null);
            formAddEditPatient.ShowDialog();
        }

        private void buttonActivatePatient_Click(object sender, EventArgs e)
        {
            PatientModel patient = PatientModel.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);

            if (patient.IsActive == true)
            {
                string msg = "Patient is active!";
                FormMessage FormMessage = new FormMessage(msg);
                FormMessage.ShowDialog();
                return;
            }

            FormChangeStatusOfPatient activate = new FormChangeStatusOfPatient("activate", patient, currentUser);
            activate.ShowDialog();
        }

        private void buttonDeactivatePatinet_Click(object sender, EventArgs e)
        {
            PatientModel patient = PatientModel.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);

            if (patient.IsActive == false)
            {
                string msg = "Patient is deactive!";
                FormMessage FormMessage = new FormMessage(msg);
                FormMessage.ShowDialog();
                return;
            }

            FormChangeStatusOfPatient deactivate = new FormChangeStatusOfPatient("deactivate", patient, currentUser);
            deactivate.ShowDialog();
        }

        private void buttonRemovePatient_Click(object sender, EventArgs e)
        {
            PatientModel patient = PatientModel.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);

            string msg = "A deleted patient cannot be restored!";
            FormMessage FormMessage = new FormMessage(msg);
            FormMessage.ShowDialog();

            FormChangeStatusOfPatient remove = new FormChangeStatusOfPatient("remove", patient, currentUser);
            remove.ShowDialog();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatientList.SelectedRows.Count == 0)
            {
                return;
            }
            PatientModel patient = new PatientModel();
            patient = PatientModel.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);

            FormAddEditPatient formAddEditPatient = new FormAddEditPatient(currentUser, patient);
            Hide();
            formAddEditPatient.ChangeTitle("Edit patient");
            formAddEditPatient.ShowDialog();
        }

        private void button_ShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatientList.SelectedRows.Count == 0)
            {
                return;
            }
            ShowDetails();


        }

        private void ShowDetails()
        {
            PatientModel patient = new PatientModel();
            patient = PatientModel.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);
            FormAddEditPatient formAddEditPatient = new FormAddEditPatient(currentUser, patient);
            formAddEditPatient.ChangeTitle("Details");
            formAddEditPatient.ReadOnlyControls();
            formAddEditPatient.buttonAddEditPatient.Visible = false;
            Hide();
            formAddEditPatient.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Clear Filters
            DisplayPatientsList();
            textBox1_Name.Text = null;
            TextBox_PESEL.Text = null;
            dateTimePicker1.Text = null;
            dateTimePicker2.Text = null;
        }

        private void buttonShowFilters_Click(object sender, EventArgs e)
        {
            //Filters
            PatientService patientService = new PatientService();
            List<PatientModel> FiltredPatients = patientService.FilterPatient(textBox1_Name.Text, TextBox1_PESEL.Text);
            dataGridViewPatientList.DataSource = FiltredPatients;

      
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_PESEL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
